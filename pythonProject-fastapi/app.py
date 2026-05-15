from datetime import datetime, UTC, timedelta
from typing import Annotated

import jwt
from fastapi import FastAPI, HTTPException
from fastapi.params import Depends
from fastapi.security import OAuth2PasswordBearer, OAuth2PasswordRequestForm
from sqlalchemy.orm import Session

from config import settings
from database import get_db, get_db_sa
from database.applications import select_applications, select_application_by_id, insert_application, create_table
from database.users import select_users, insert_user, get_user
from schema import Application, ApplicationCreate, UserCreate, UserResponse, TokenResponse, UserLogin

oauth2_schema = OAuth2PasswordBearer(tokenUrl='login')

app = FastAPI(
    debug=True,
    title="Заявки",
    summary="Тестим"
)



@app.get('/applications', response_model=list[Application])
def get_applications(q: str | None = None) -> list[Application]:
    return select_applications(get_cursor=get_db, search=q)


@app.get('/applications/{application_id}', response_model=Application)
def get_one_application(application_id: int) -> Application:
    application = select_application_by_id(get_cursor=get_db, id=application_id)
    if not application:
        raise HTTPException(
            status_code=404,
            detail=f'Application with id {application_id} not found'
        )
    return application


@app.post('/applications', response_model=Application)
def create_application(payload: ApplicationCreate, token: Annotated[str, Depends(oauth2_schema)] ) -> Application:
    try:
        print(token)
        return insert_application(get_cursor=get_db, payload=payload)
    except Exception:
        raise HTTPException(
            status_code=422,
            detail=f'Error creating application: unprocessable payload'
        )


@app.get('/users', response_model=list[UserResponse])
def get_users(session: Annotated[Session, Depends(get_db_sa)]) -> list[UserResponse]:
    return select_users(session=session)


@app.post('/register', response_model=UserResponse)
def create_user(payload: UserCreate, session: Annotated[Session, Depends(get_db_sa)]) -> UserResponse:
    return insert_user(session=session, payload=payload)


@app.post('/login', response_model=TokenResponse)
def authenticate_user(
        payload: Annotated[OAuth2PasswordRequestForm, Depends()],
        session: Annotated[Session, Depends(get_db_sa)]
):
    user = get_user(session=session, payload=payload)
    if not user:
        raise HTTPException(
            status_code=401,
            detail=f'User with passed credentials not found'
        )

    jwt_payload = {
        'sub': user.username,
        'iat': datetime.now(tz=UTC),
        'exp': datetime.now(tz=UTC) + timedelta(minutes=30)
    }

    token = jwt.encode(jwt_payload, settings.JWT_SECRET, "HS256")

    return TokenResponse(access_token=token, token_type="bearer")
