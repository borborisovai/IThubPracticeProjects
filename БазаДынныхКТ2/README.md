Попытка открыть содержимое базы данных через MySQL Workbanch выдаёт такую ошибку:

```
MySQL Error
An error occurred retrieving information about the schema.
Query: SELECT '<global>' as scope, user, host, Select_priv AS 'Select', Insert_priv AS 'Insert', Update_priv AS 'Update', Delete_priv AS 'Delete', Create_priv AS 'Create', Drop_priv AS 'Drop', Grant_priv AS 'Grant', References_priv AS 'References', Index_priv AS 'Index', Alter_priv AS 'Alter', Create_View_priv AS 'Create View',Show_view_priv AS 'Show view', Trigger_priv AS 'Trigger', Delete_versioning_rows_priv AS 'Delete versioning rows' FROM mysql.user WHERE Select_priv = 'Y' OR Insert_priv = 'Y' OR Update_priv = 'Y' OR Delete_priv = 'Y' OR Create_priv = 'Y' OR Drop_priv = 'Y' OR Grant_priv = 'Y' OR References_priv = 'Y' OR Index_priv = 'Y' OR Alter_priv = 'Y' OR Create_View_priv = 'Y' OR Show_view_priv = 'Y' OR Trigger_priv = 'Y' OR Delete_versioning_rows_priv = 'Y'
Error: Unknown column 'Delete_versioning_rows_priv' in 'SELECT'
```

Поэтому все действия по заполнению таблиц проводились в программе phpMyAdmin