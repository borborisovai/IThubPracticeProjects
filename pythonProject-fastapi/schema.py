from typing import Literal
from pydantic import BaseModel


class Application(BaseModel):
    id: int
    title: str


class ApplicationCreate(BaseModel):
    title: str


class User(BaseModel):
    id: int
    username: str
    password: str
    role: Literal["user"] | Literal["superuser"]


class UserResponse(BaseModel):
    id: int
    username: str
    role: Literal["user"] | Literal["superuser"]


class UserCreate(BaseModel):
    username: str
    password: str


class UserLogin(UserCreate):
    pass


class TokenResponse(BaseModel):
    access_token: str
    token_type: str