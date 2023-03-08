CREATE TABLE Tenant (
    ID int NOT NULL PRIMARY KEY,
    personal_account nvarchar(255) NOT NULL,
    firstname nvarchar(50) NOT NULL,
    middlename nvarchar(50),
    lastname nvarchar(50),
    phone nvarchar(16),
    pass_hash binary(100) NOT NULL,
    CONSTRAINT UN_Tenant_ID UNIQUE(ID),
)

CREATE TABLE Flat (
    ID int NOT NULL PRIMARY KEY,
    street nvarchar(50) NOT NULL,
    house int NOT NULL,
    number int NOT NULL,
    count_resident int NOT NULL,
    [square] float NOT NULL,
    tenant_id int NOT NULL,
    FOREIGN KEY (tenant_id) REFERENCES Tenant (ID),
    CONSTRAINT UN_Flat_ID UNIQUE(ID),
)

CREATE TABLE [Service] (
    ID int NOT NULL PRIMARY KEY,
    code int NOT NULL,
    [type] nvarchar(50) NOT NULL,
    unit nvarchar(50) NOT NULL,
    rate float NOT NULL,
    CONSTRAINT UN_Service_ID UNIQUE(ID)
)

CREATE TABLE ServiceInvoice (
    ID int NOT NULL PRIMARY KEY,
    consumption float NOT NULL,
    by_date datetime NOT NULL,
    paid_on_time bit NOT NULL,
    payment_date datetime,
    tenant_id int NOT NULL,
    service_id int NOT NULL,
    FOREIGN KEY (tenant_id) REFERENCES Tenant (ID),
    FOREIGN KEY (service_id) REFERENCES [Service] (ID),
    CONSTRAINT UN_ServiceInvoice_ID UNIQUE(ID),
)

