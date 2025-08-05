CALL AddColumnIfNotExists('test','Students','FirstName','NVARCHAR(127)');
CALL AddColumnIfNotExists('test','Students','LastName','NVARCHAR(127)');
CALL DropColumnIfNotExists('test','Students','Name');
CALL AddIndexIfNotExists('test','Students','idx_students_lastname','LastName');
CALL AddIndexIfNotExists('test','Students','idx_students_firstname','FirstName');