import sqlalchemy as sa
import sqlalchemy.orm as orm
from sqlalchemy.orm import Session
from pwdlib import PasswordHash
from config import settings

from . import engine
from schema import UserCreate, UserResponse, UserLogin

password_hasher = PasswordHash.recommended()

Base = orm.declarative_base()


class User(Base):
    __tablename__ = 'users'

    id = sa.Column('id', sa.Integer, primary_key=True)
    username = sa.Column(sa.String(50), unique=True, nullable=False)
    password = sa.Column(sa.String(100), nullable=False)
    role = sa.Column(sa.String(15), default="user", nullable=True)


def insert_user(session: Session, payload: UserCreate):
    try:
        new_user = User(**payload.model_dump())

        new_user.password = password_hasher.hash(
            payload.password,
            salt=settings.PWDLIB_SALT
        )

        session.add(new_user)
        session.commit()
        session.refresh(new_user)
        print(new_user)
        return new_user
    except Exception as error:
        raise error


def select_users(session: Session):
    return list(session.execute(sa.select(User)).scalars())


def get_user(session: Session, payload: UserLogin) -> User | None:
    statement = sa.select(User).where(User.username == payload.username)
    user = session.execute(statement).scalar_one_or_none()

    if not user:
        return None

    password_with_salt = password_hasher.hash(
        payload.password,
        salt=settings.PWDLIB_SALT
    )

    if password_with_salt != user.password:
        return None

    return user


Base.metadata.create_all(bind=engine)
