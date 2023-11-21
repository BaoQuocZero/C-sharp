/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     15/08/2021 7:34:22 SA                        */
/*==============================================================*/
create database quanlynkhk
use quanlynkhk

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HOKHAU') and o.name = 'FK_HOKHAU_DANGKY_PHUONGXA')
alter table HOKHAU
   drop constraint FK_HOKHAU_DANGKY_PHUONGXA
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
            and   name  = 'DANGKY_FK'
            and   indid > 0
            and   indid < 255)
   drop index HOKHAU.DANGKY_FK
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
   SOSO                 varchar(20)          not null,
   MAPX                 varchar(10)          not null,
   HOTENCH              varchar(50)          null,
   SONHA                varchar(20)          null,
   TENDUONG             varchar(50)          null,
   KHUPHOAP             varchar(10)          null,
   constraint PK_HOKHAU primary key nonclustered (SOSO)
)
go

/*==============================================================*/
/* Index: DANGKY_FK                                             */
/*==============================================================*/
create index DANGKY_FK on HOKHAU (
MAPX ASC
)
go

/*==============================================================*/
/* Table: NHANKHAU                                              */
/*==============================================================*/
create table NHANKHAU (
   MANK                 varchar(10)          not null,
   SOSO                 varchar(20)          not null,
   HOTEN                varchar(50)          null,
   GIOITINH             varchar(5)           null,
   NGAYSINH             datetime             null,
   constraint PK_NHANKHAU primary key nonclustered (MANK)
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
   MAPX                 varchar(10)          not null,
   MAQH                 varchar(10)          not null,
   TENPX                varchar(50)          null,
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
   MAQH                 varchar(10)          not null,
   TENQH                varchar(50)          null,
   constraint PK_QUANHUYEN primary key nonclustered (MAQH)
)
go

alter table HOKHAU
   add constraint FK_HOKHAU_DANGKY_PHUONGXA foreign key (MAPX)
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

