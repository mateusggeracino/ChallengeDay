
CREATE TABLE Question
(
	Id integer identity(1,1),
	Description varchar(250)
);

ALTER TABLE Question
ADD CONSTRAINT PK_QUESTION PRIMARY KEY (Id);

CREATE TABLE QuestionPoint
(
	Id integer identity(1,1),
	QuestionId integer,
	Quantity integer,
	Point integer
);

ALTER TABLE QuestionPoint
ADD CONSTRAINT PK_QUESTION_POINT PRIMARY KEY (Id);

ALTER TABLE QuestionPoint
ADD CONSTRAINT FK_QUESTION FOREIGN KEY (QuestionId) REFERENCES Question(Id);


CREATE TABLE Client
(
	Id integer identity(1,1),
	Fullname varchar(120)
);

ALTER TABLE Client
ADD CONSTRAINT PK_CLIENT PRIMARY KEY (Id);

CREATE TABLE Awsner
(
	Id integer identity(1,1),
	ClientId integer,
	QuestionId integer,
	Awsner int
);

ALTER TABLE Awsner
ADD CONSTRAINT PK_AWSNER PRIMARY KEY (Id);

ALTER TABLE Awsner
ADD CONSTRAINT FK_Awsner_Client FOREIGN KEY (ClientId) REFERENCES Client(Id);

ALTER TABLE Awsner
ADD CONSTRAINT FK_Awsner_Question FOREIGN KEY (QuestionId) REFERENCES Question(Id);