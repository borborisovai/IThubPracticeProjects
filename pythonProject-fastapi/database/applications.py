import sqlite3
from schema import Application, ApplicationCreate


def select_applications(*, get_cursor: sqlite3.Connection, search: str | None) -> list[Application]:
    where_statement = f'where title like %{search}%' if search else ''
    select_statement = f'select * from applications {where_statement}'
    with get_cursor() as cursor:
        rows = cursor.execute(select_statement).fetchall()
    return [Application(id=id, title=title) for id, title in rows]


def select_application_by_id(*, get_cursor: sqlite3.Connection, id: int) -> Application | None:
    select_statement = f'select * from applications where id = {id}'
    with get_cursor() as cursor:
        row = cursor.execute(select_statement).fetchone()
    return Application(id=row[0], title=row[1]) if row else None


def insert_application(*, get_cursor: sqlite3.Connection, payload: ApplicationCreate) -> Application:
    insert_statement = f'insert into applications (title) values (?,)'
    select_statement = f'select * from applications order by id desc'

    try:
        with get_cursor() as cursor:
            cursor.execute(insert_statement, (payload.title,))
            new_row = cursor.execute(select_statement).fetchone()
            return Application(id=new_row[0], title=new_row[1])

    except sqlite3.IntegrityError:
        raise

def create_table(connection: sqlite3.Connection):
    cursor = connection.cursor()
    cursor.execute('''create table if not exists applications (
        id INTEGER PRIMARY KEY,
        title TEXT NOT NULL
    )''')
    connection.commit()


def seed_table(connection: sqlite3.Connection):
    cursor = connection.cursor()
    try:
        cursor.execute('''insert into applications values 
            (1, "first"),
            (2, "second"),
            (3, "not-second")
        ''')
        connection.commit()
    except sqlite3.IntegrityError:
        connection.rollback()
