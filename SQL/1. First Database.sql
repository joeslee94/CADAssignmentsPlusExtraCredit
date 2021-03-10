--Creates tables
CREATE TABLE student
	(
	student_id INT IDENTITY(1,1), --Identity(1,1) autoincrements from 1 up by 1.
	firstname VARCHAR(30) NOT NULL, --field must be filled out
	major VARCHAR(20) NULL, --UNIQUE means that there cannot be a duplicate within the column
	gpa DECIMAL(3, 2) NULL, --gpa is defined as 3 digits with 2 of them being after the decimal
	payment_remaining INT NULL,
	dormitory VARCHAR(30) NULL, --defines where the student resides

	PRIMARY KEY (student_id), --MUST BE UNIQUE AND NOT NULL
	CHECK (student_id >= 1), --makes sure that student id starts at 1 (kind of redundant given it auto increments starting at 1)
	CHECK (gpa >= 0),
	CHECK (dormitory IN('Alice LLoyd', 'Baits', 'Hartmand', 'Booker')),
	);
	GO
	
	--INSERT
	INSERT INTO student VALUES('Jack', 'Biology', NULL, NULL, 'Alice Lloyd'); --Inserts information into the table
	INSERT INTO student VALUES('Kate', 'Sociology', 3.5, NULL, 'Baits'); --**CAN USE SAME LINE ABOVE TO INSERT DATA
	INSERT INTO student VALUES('James', NULL, NULL, 40000, 'Hartmand'); --**IF WE ONLY HAVE DATA FOR CERTAIN FIELDS BUT MUST PUT IN PRIM KEY
	INSERT INTO student VALUES('Jack', 'Biology', 4.0, 30000, 'Booker'); --Inserts information into the table
	INSERT INTO student VALUES('Mike', 'Computer Science', 2.7, 20000, NULL); --Inserts information into the table
	INSERT INTO student VALUES('Claire', 'Computer Science', 3.7, 1000, NULL); --Inserts information into the table

	GO

	--UPDATE
	UPDATE student --UPDATES data within the table SET outlines the new piece of data and WHERE is the old piece of data the UPDATE statement reads
	SET major = 'Bio'
	WHERE major = 'Biology';
	GO
	UPDATE student
	SET major = 'Comp Sci'
	WHERE major = 'Computer Science';
	GO
	UPDATE student
	SET major = 'Bio'
	WHERE student_id = 3;
	GO
	UPDATE student
	SET major = 'Biochemistry'
	WHERE major = 'Bio' OR major = 'Chemistry';
	GO
	UPDATE student
	SET firstname = 'Thomas', major = 'Undecided'
	WHERE student_id = 6; --optional
	GO
	UPDATE student
	SET firstname = 'Thomas', major = 'Undecided'
	WHERE student_id = 6; --optional, if deleted, everything within the column within the SET statement is changed to what set is equated to
	GO
	
	--DELETE
	DELETE FROM student --deletes specific rows
	WHERE student_id = 5;
	GO
	DELETE FROM student; --deletes all data within the table
	GO

	--SELECT
	SELECT * FROM student; --grabs all the information from the table student due to the asterisk
	GO
	SELECT student_id, student.firstname, student.major FROM student --grab specific data from table annotated by period and data type desired
	ORDER BY major DESC, student_id DESC; --default is ascending (ASC), if I type in DESC after condition in which I want them to be ordered in, it will be descending order
	GO
	SELECT TOP 2 * FROM student
	ORDER BY student_id DESC;
	GO
	SELECT firstname, major
	FROM student
	WHERE major = 'Biology' OR major = 'Biochemistry';
	GO
	--WHERE COMPARISON OPERATORS <, >, <=, >=, =, <> (not equal to), AND, OR, IN()
	SELECT *
	FROM student
	WHERE major <> 'Biology';
	GO
	SELECT *
	FROM student
	WHERE student_id > 2;
	GO
	SELECT *
	FROM student
	WHERE firstname IN ('Claire', 'Kate', 'Mike') AND student_id > 2;
	GO

	--EXEC
	EXEC sp_help student; --describes the table
	GO

	--DROP
	DROP TABLE IF EXISTS student; --deletes created table
	GO

	--ALTER
	ALTER TABLE student ADD gpa DECIMAL(3, 2); --can add a column to the table
	GO
	ALTER TABLE student DROP COLUMN gpa; --can delete a column to the table
	GO