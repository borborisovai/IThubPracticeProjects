from pydantic import Field
from pydantic_settings import BaseSettings, SettingsConfigDict

class Settings(BaseSettings):
    DATABASE_URI: str
    PWDLIB_SALT: bytes = Field(min_length=32)
    JWT_SECRET: bytes = Field(min_length=32)

    model_config = SettingsConfigDict(env_file='.env.local')


settings = Settings()