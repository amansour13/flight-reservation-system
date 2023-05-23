
/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2005                    */
/* Created on:     5/19/2023 9:06:08 PM                         */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('AIRCRAFT') and o.name = 'FK_AIRCRAFT_ADD_ADMIN')
alter table AIRCRAFT
   drop constraint FK_AIRCRAFT_ADD_ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BOOKING') and o.name = 'FK_BOOKING_BOOKING_CUSTOMER')
alter table BOOKING
   drop constraint FK_BOOKING_BOOKING_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BOOKING') and o.name = 'FK_BOOKING_BOOKING2_FLIGHT')
alter table BOOKING
   drop constraint FK_BOOKING_BOOKING2_FLIGHT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FLIGHT') and o.name = 'FK_FLIGHT_CONTAIN_AIRCRAFT')
alter table FLIGHT
   drop constraint FK_FLIGHT_CONTAIN_AIRCRAFT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FLIGHT') and o.name = 'FK_FLIGHT_CREATE_ADMIN')
alter table FLIGHT
   drop constraint FK_FLIGHT_CREATE_ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LUGGAGE_WEAK_ENTITY_') and o.name = 'FK_LUGGAGE__HAS_CUSTOMER')
alter table LUGGAGE_WEAK_ENTITY_
   drop constraint FK_LUGGAGE__HAS_CUSTOMER
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ADMIN')
            and   type = 'U')
   drop table ADMIN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('AIRCRAFT')
            and   name  = 'ADD_FK'
            and   indid > 0
            and   indid < 255)
   drop index AIRCRAFT.ADD_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('AIRCRAFT')
            and   type = 'U')
   drop table AIRCRAFT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BOOKING')
            and   name  = 'BOOKING2_FK'
            and   indid > 0
            and   indid < 255)
   drop index BOOKING.BOOKING2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BOOKING')
            and   name  = 'BOOKING_FK'
            and   indid > 0
            and   indid < 255)
   drop index BOOKING.BOOKING_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BOOKING')
            and   type = 'U')
   drop table BOOKING
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CUSTOMER')
            and   type = 'U')
   drop table CUSTOMER
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('FLIGHT')
            and   name  = 'CREATE_FK'
            and   indid > 0
            and   indid < 255)
   drop index FLIGHT.CREATE_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('FLIGHT')
            and   name  = 'CONTAIN_FK'
            and   indid > 0
            and   indid < 255)
   drop index FLIGHT.CONTAIN_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('FLIGHT')
            and   type = 'U')
   drop table FLIGHT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LUGGAGE_WEAK_ENTITY_')
            and   name  = 'HAS_FK'
            and   indid > 0
            and   indid < 255)
   drop index LUGGAGE_WEAK_ENTITY_.HAS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LUGGAGE_WEAK_ENTITY_')
            and   type = 'U')
   drop table LUGGAGE_WEAK_ENTITY_
go

/*==============================================================*/
/* Table: ADMIN                                                 */
/*==============================================================*/
create table ADMIN (
   ADMINID              int   identity(1,1)  not null,
   AFNAME               text                 null,
   ALNAME               text                 null,
   AMAIL                varchar(50)  unique  null,
   APASSWORD            text                 null,
   constraint PK_ADMIN primary key nonclustered (ADMINID)
)
go

/*==============================================================*/
/* Table: AIRCRAFT                                              */
/*==============================================================*/
create table AIRCRAFT (
   AIRCRAFTID           int  identity(1,1)   not null,
   ADMINID              int                  null,
   CAPACITY             int                  not null,
   MANFACTURER          text                 null,
   DISTANCEALLOWED      double precision     not null,
   constraint PK_AIRCRAFT primary key nonclustered (AIRCRAFTID)
)
go

/*==============================================================*/
/* Index: ADD_FK                                                */
/*==============================================================*/
create index ADD_FK on AIRCRAFT (
ADMINID ASC
)
go

/*==============================================================*/
/* Table: BOOKING                                               */
/*==============================================================*/
create table BOOKING (
   SSN                  int                  not null,
   FLIGHTID             int                  not null,
   SEATNUMBER           int                  not null,
   CLASS                char(1)              null,
   STATE                text                 not null,
   constraint PK_BOOKING primary key (SSN, FLIGHTID)
)
go

/*==============================================================*/
/* Index: BOOKING_FK                                            */
/*==============================================================*/
create index BOOKING_FK on BOOKING (
SSN ASC
)
go

/*==============================================================*/
/* Index: BOOKING2_FK                                           */
/*==============================================================*/
create index BOOKING2_FK on BOOKING (
FLIGHTID ASC
)
go

/*==============================================================*/
/* Table: CUSTOMER                                              */
/*==============================================================*/
create table CUSTOMER (
   SSN                  int                  not null,
   CFNAME               text                 not null,
   CLNAME               text                 not null,
   CPASSWORD            text                 not null,
   BIRTHDATE            date                 not null,
   CMAIL                varchar(50)  unique  not null,
   constraint PK_CUSTOMER primary key nonclustered (SSN)
)
go

/*==============================================================*/
/* Table: FLIGHT                                                */
/*==============================================================*/
create table FLIGHT (
   FLIGHTID             int identity(1,1)    not null,
   AIRCRAFTID           int                  null,
   ADMINID              int                  not null,
   SEATSNUMBER          int                  not null,
   SOURCE               text                 not null,
   DESTINATION          text                 not null,
   OUTGOINGDATE         datetime             not null,
   ARRIVINGDATE         datetime             not null,
   constraint PK_FLIGHT primary key nonclustered (FLIGHTID)
)
go

/*==============================================================*/
/* Index: CONTAIN_FK                                            */
/*==============================================================*/
create index CONTAIN_FK on FLIGHT (
AIRCRAFTID ASC
)
go

/*==============================================================*/
/* Index: CREATE_FK                                             */
/*==============================================================*/
create index CREATE_FK on FLIGHT (
ADMINID ASC
)
go

/*==============================================================*/
/* Table: LUGGAGE_WEAK_ENTITY_                                  */
/*==============================================================*/
create table LUGGAGE_WEAK_ENTITY_ (
   SSN                  int                  not null,
   LID                  int                  not null,
   WEIGHT               int                  not null,
   constraint PK_LUGGAGE_WEAK_ENTITY_ primary key nonclustered (SSN, LID)
)
go

/*==============================================================*/
/* Index: HAS_FK                                                */
/*==============================================================*/
create index HAS_FK on LUGGAGE_WEAK_ENTITY_ (
SSN ASC
)
go

alter table AIRCRAFT
   add constraint FK_AIRCRAFT_ADD_ADMIN foreign key (ADMINID)
      references ADMIN (ADMINID)
go

alter table BOOKING
   add constraint FK_BOOKING_BOOKING_CUSTOMER foreign key (SSN)
      references CUSTOMER (SSN)
go

alter table BOOKING
   add constraint FK_BOOKING_BOOKING2_FLIGHT foreign key (FLIGHTID)
      references FLIGHT (FLIGHTID)
go

alter table FLIGHT
   add constraint FK_FLIGHT_CONTAIN_AIRCRAFT foreign key (AIRCRAFTID)
      references AIRCRAFT (AIRCRAFTID)
go

alter table FLIGHT
   add constraint FK_FLIGHT_CREATE_ADMIN foreign key (ADMINID)
      references ADMIN (ADMINID)
go

alter table LUGGAGE_WEAK_ENTITY_
   add constraint FK_LUGGAGE__HAS_CUSTOMER foreign key (SSN)
      references CUSTOMER (SSN)
go

insert into ADMIN 
VALUES('Karim', 'Mohsen', 'karim.mohsen.103@gmail.com','karim')

  ALTER TABLE BOOKING 
  DROP CONSTRAINT PK_BOOKING;

  ALTER TABLE BOOKING
ADD CONSTRAINT PK_BOOKING PRIMARY KEY(SSN,FLIGHTID,SEATNUMBER)

 ALTER TABLE BOOKING
 ADD PRICE float ;
 
 
-- Insert random data into ADMIN table
INSERT INTO ADMIN (AFNAME, ALNAME, AMAIL, APASSWORD)
VALUES
  ('John', 'Doe', 'john.doe@example.com', 'password1'),
  ('Jane', 'Smith', 'jane.smith@example.com', 'password2'),
  ('Mike', 'Johnson', 'mike.johnson@example.com', 'password3');

-- Insert random data into AIRCRAFT table
INSERT INTO AIRCRAFT (ADMINID, CAPACITY, MANFACTURER, DISTANCEALLOWED)
VALUES
  (1, 300, 'Manufacturer A', 1000.0),
  (2, 200, 'Manufacturer B', 1200.0),
  (1, 120, 'Manufacturer C', 900.0);

-- Insert random data into CUSTOMER table
INSERT INTO CUSTOMER (SSN, CFNAME, CLNAME, CPASSWORD, BIRTHDATE, CMAIL)
VALUES
  (123456789, 'Alice', 'Johnson', 'password4', '1990-01-01', 'alice.johnson@example.com'),
  (987654321, 'Bob', 'Williams', 'password5', '1985-05-15', 'bob.williams@example.com'),
  (555555555, 'Eve', 'Davis', 'password6', '1998-12-31', 'eve.davis@example.com');

-- Insert random data into FLIGHT table
INSERT INTO FLIGHT (AIRCRAFTID, ADMINID, SEATSNUMBER, SOURCE, DESTINATION, OUTGOINGDATE, ARRIVINGDATE, STANDARDPRICE)
VALUES
  (1, 1, 200, 'City A', 'City B', '2023-05-25 08:00:00', '2023-05-25 10:00:00', 100),
  (2, 2, 150, 'City B', 'City C', '2023-05-26 09:30:00', '2023-05-26 11:30:00', 100),
  (1, 2, 180, 'City A', 'City C', '2023-05-27 11:00:00', '2023-05-27 13:00:00', 100);