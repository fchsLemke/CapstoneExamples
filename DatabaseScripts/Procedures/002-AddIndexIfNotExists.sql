CREATE PROCEDURE IF NOT EXISTS AddIndexIfNotExists(
    DatabaseName NVARCHAR(255),
    TableName NVARCHAR(255),
    IndexName NVARCHAR(255),
    `Columns` NVARCHAR(511)
    )
BEGIN
    SET @statement = (SELECT IF(
        (SELECT COUNT(*) FROM INFORMATION_SCHEMA.STATISTICS
        WHERE (table_name = TableName)
        AND (table_schema = DatabaseName)
        AND (index_name = IndexName)) > 0,
        'SELECT 1', -- Column exists, do nothing
        CONCAT('ALTER TABLE ', TableName, ' ADD Index ', IndexName, '(', `Columns`,")")
    ));
    PREPARE `statement` FROM @statement;
    EXECUTE `statement`;
    DEALLOCATE PREPARE `statement`;
END;
