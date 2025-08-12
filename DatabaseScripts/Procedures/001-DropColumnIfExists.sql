CREATE PROCEDURE IF NOT EXISTS DropColumnIfNotExists(
    DatabaseName NVARCHAR(255),
    TableName NVARCHAR(255),
    ColumnName NVARCHAR(255)
    )
BEGIN
    SET @statement = (SELECT IF(
        (SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS
        WHERE (table_name = TableName)
        AND (table_schema = DatabaseName)
        AND (column_name = ColumnName)) = 0,
        'SELECT 1', -- Column exists, do nothing
        CONCAT('ALTER TABLE ', DatabaseName, '.', TableName, ' DROP ', ColumnName)
    ));
    PREPARE `statement` FROM @statement;
    EXECUTE `statement`;
    DEALLOCATE PREPARE `statement`;
END;