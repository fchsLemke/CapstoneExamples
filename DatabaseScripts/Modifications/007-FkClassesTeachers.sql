CALL AddColumnIfNotExists('test','Classes','TeacherId','NVARCHAR(127),
ADD FOREIGN KEY IF NOT EXISTS (`TeacherId`) REFERENCES Teachers(`Id`)')
