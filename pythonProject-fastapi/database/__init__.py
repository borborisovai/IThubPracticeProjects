import sqlite3
from contextlib import contextmanager

import sqlalchemy as sa
import sqlalchemy.orm as orm

from config import settings


def get_db_sa():
    session = Session()
    try:
        yield session
    finally:
        session.close()


@contextmanager
def get_db():
    connection = sqlite3.connect(settings.DATABASE_URI)
    try:
        cursor = connection.cursor()
        yield cursor
    except Exception as e:
        connection.rollback()
        raise e
    else:
        connection.commit()
    finally:
        connection.close()


engine = sa.create_engine(
    f'sqlite:///{settings.DATABASE_URI}',
    echo=True
)

Session = orm.sessionmaker(bind=engine, autoflush=False, autocommit=False)
