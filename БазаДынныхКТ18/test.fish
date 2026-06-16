#!/usr/bin/env fish
set -x DB_HOST "127.0.0.1"
set -x DB_PORT 3306
set -x DB_USER borisov
set -x DB_PASS "jH4pSd#fG9qW"
set -x DB_NAME exam_borisov
set -x MYSQL_CMD mariadb -h $DB_HOST -P $DB_PORT -u $DB_USER -p$DB_PASS -D $DB_NAME -N -B

# ---
set tables (eval $MYSQL_CMD "SHOW TABLES;")
echo $tables
