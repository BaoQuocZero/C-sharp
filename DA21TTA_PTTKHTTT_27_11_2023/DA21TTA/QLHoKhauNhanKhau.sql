/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     13/11/2023 1:23:52 PM                        */
/*==============================================================*/
create database QLHoKhauNhanKhau
go
use QLHoKhauNhanKhau
go
if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HOKHAU') and o.name = 'FK_HOKHAU_QUANLY_PHUONGXA')
alter table HOKHAU
   drop constraint FK_HOKHAU_QUANLY_PHUONGXA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('NHANKHAU') and o.name = 'FK_NHANKHAU_CUA_HOKHAU')
alter table NHANKHAU
   drop constraint FK_NHANKHAU_CUA_HOKHAU
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHUONGXA') and o.name = 'FK_PHUONGXA_THUOC_QUANHUYE')
alter table PHUONGXA
   drop constraint FK_PHUONGXA_THUOC_QUANHUYE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HOKHAU')
            and   name  = 'QUANLY_FK'
            and   indid > 0
            and   indid < 255)
   drop index HOKHAU.QUANLY_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('HOKHAU')
            and   type = 'U')
   drop table HOKHAU
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('NHANKHAU')
            and   name  = 'CUA_FK'
            and   indid > 0
            and   indid < 255)
   drop index NHANKHAU.CUA_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('NHANKHAU')
            and   type = 'U')
   drop table NHANKHAU
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PHUONGXA')
            and   name  = 'THUOC_FK'
            and   indid > 0
            and   indid < 255)
   drop index PHUONGXA.THUOC_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PHUONGXA')
            and   type = 'U')
   drop table PHUONGXA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('QUANHUYEN')
            and   type = 'U')
   drop table QUANHUYEN
go

/*==============================================================*/
/* Table: HOKHAU                                                */
/*==============================================================*/
create table HOKHAU (
   SOSO                 int                  not null,
   MAPX                 int                  not null,
   HOTENCHUHO           varchar(30)          null,
   SONHA                int                  null,
   TENDUONG             varchar(100)         null,
   KHUPHO               varchar(100)         null,
   constraint PK_HOKHAU primary key nonclustered (SOSO)
)
go

/*==============================================================*/
/* Index: QUANLY_FK                                             */
/*==============================================================*/
create index QUANLY_FK on HOKHAU (
MAPX ASC
)
go

/*==============================================================*/
/* Table: NHANKHAU                                              */
/*==============================================================*/
create table NHANKHAU (
   MASOTT               int                  not null,
   SOSO                 int                  not null,
   HOTEN                varchar(30)          null,
   GOITINH              varchar(4)           null,
   NGAYSINH             datetime             null,
   constraint PK_NHANKHAU primary key nonclustered (MASOTT)
)
go

/*==============================================================*/
/* Index: CUA_FK                                                */
/*==============================================================*/
create index CUA_FK on NHANKHAU (
SOSO ASC
)
go

/*==============================================================*/
/* Table: PHUONGXA                                              */
/*==============================================================*/
create table PHUONGXA (
   MAPX                 int                  not null,
   MAQH                 int                  not null,
   TENPX                varchar(100)         null,
   constraint PK_PHUONGXA primary key nonclustered (MAPX)
)
go

/*==============================================================*/
/* Index: THUOC_FK                                              */
/*==============================================================*/
create index THUOC_FK on PHUONGXA (
MAQH ASC
)
go

/*==============================================================*/
/* Table: QUANHUYEN                                             */
/*==============================================================*/
create table QUANHUYEN (
   MAQH                 int                  not null,
   TENQH                varchar(100)         null,
   constraint PK_QUANHUYEN primary key nonclustered (MAQH)
)
go

alter table HOKHAU
   add constraint FK_HOKHAU_QUANLY_PHUONGXA foreign key (MAPX)
      references PHUONGXA (MAPX)
go

alter table NHANKHAU
   add constraint FK_NHANKHAU_CUA_HOKHAU foreign key (SOSO)
      references HOKHAU (SOSO)
go

alter table PHUONGXA
   add constraint FK_PHUONGXA_THUOC_QUANHUYE foreign key (MAQH)
      references QUANHUYEN (MAQH)
go
SELECT SOSO as [Số sổ]
FROM dbo.HOKHAU

SELECT *
FROM dbo.NHANKHAU

SELECT *
FROM dbo.PHUONGXA

SELECT *
FROM dbo.QUANHUYEN

-- Thêm dữ liệu cho bảng QUANHUYEN
INSERT INTO QUANHUYEN (MAQH, TENQH)
VALUES 
   (1, N'Quận 1'),
   (2, N'Quận 2'),
   (3, N'Quận 3'),
   (4, N'Quận 4');
 
