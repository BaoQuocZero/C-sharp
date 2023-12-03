/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     30/10/2023 4:10:48 PM                        */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BAN') and o.name = 'FK_BAN_BAN_SACH')
alter table BAN
   drop constraint FK_BAN_BAN_SACH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BAN') and o.name = 'FK_BAN_BAN2_HOADON')
alter table BAN
   drop constraint FK_BAN_BAN2_HOADON
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('KESACH') and o.name = 'FK_KESACH_QUAN_LY_NHANVIEN')
alter table KESACH
   drop constraint FK_KESACH_QUAN_LY_NHANVIEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('KESACH') and o.name = 'FK_KESACH__AT_THELOAI')
alter table KESACH
   drop constraint FK_KESACH__AT_THELOAI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LAP') and o.name = 'FK_LAP_LAP_HOADON')
alter table LAP
   drop constraint FK_LAP_LAP_HOADON
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LAP') and o.name = 'FK_LAP_LAP2_NHANVIEN')
alter table LAP
   drop constraint FK_LAP_LAP2_NHANVIEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('NHAP') and o.name = 'FK_NHAP_NHAP_PHIEUNHA')
alter table NHAP
   drop constraint FK_NHAP_NHAP_PHIEUNHA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('NHAP') and o.name = 'FK_NHAP_NHAP2_SACH')
alter table NHAP
   drop constraint FK_NHAP_NHAP2_SACH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHIEUNHAP') and o.name = 'FK_PHIEUNHA_CUA_NHACUNGC')
alter table PHIEUNHAP
   drop constraint FK_PHIEUNHA_CUA_NHACUNGC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHIEUNHAP') and o.name = 'FK_PHIEUNHA_GHI_NHANVIEN')
alter table PHIEUNHAP
   drop constraint FK_PHIEUNHA_GHI_NHANVIEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SACH') and o.name = 'FK_SACH_CO_THELOAI')
alter table SACH
   drop constraint FK_SACH_CO_THELOAI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TRUC') and o.name = 'FK_TRUC_TRUC_NHANVIEN')
alter table TRUC
   drop constraint FK_TRUC_TRUC_NHANVIEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TRUC') and o.name = 'FK_TRUC_TRUC2_CATRUC')
alter table TRUC
   drop constraint FK_TRUC_TRUC2_CATRUC
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BAN')
            and   name  = 'BAN2_FK'
            and   indid > 0
            and   indid < 255)
   drop index BAN.BAN2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BAN')
            and   name  = 'BAN_FK'
            and   indid > 0
            and   indid < 255)
   drop index BAN.BAN_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BAN')
            and   type = 'U')
   drop table BAN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CATRUC')
            and   type = 'U')
   drop table CATRUC
go

if exists (select 1
            from  sysobjects
           where  id = object_id('HOADON')
            and   type = 'U')
   drop table HOADON
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('KESACH')
            and   name  = 'QUAN_LY_FK'
            and   indid > 0
            and   indid < 255)
   drop index KESACH.QUAN_LY_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('KESACH')
            and   name  = '_AT_FK'
            and   indid > 0
            and   indid < 255)
   drop index KESACH._AT_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('KESACH')
            and   type = 'U')
   drop table KESACH
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LAP')
            and   name  = 'LAP2_FK'
            and   indid > 0
            and   indid < 255)
   drop index LAP.LAP2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LAP')
            and   name  = 'LAP_FK'
            and   indid > 0
            and   indid < 255)
   drop index LAP.LAP_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LAP')
            and   type = 'U')
   drop table LAP
go

if exists (select 1
            from  sysobjects
           where  id = object_id('NHACUNGCAP')
            and   type = 'U')
   drop table NHACUNGCAP
go

if exists (select 1
            from  sysobjects
           where  id = object_id('NHANVIEN')
            and   type = 'U')
   drop table NHANVIEN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('NHAP')
            and   name  = 'NHAP2_FK'
            and   indid > 0
            and   indid < 255)
   drop index NHAP.NHAP2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('NHAP')
            and   name  = 'NHAP_FK'
            and   indid > 0
            and   indid < 255)
   drop index NHAP.NHAP_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('NHAP')
            and   type = 'U')
   drop table NHAP
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PHIEUNHAP')
            and   name  = 'GHI_FK'
            and   indid > 0
            and   indid < 255)
   drop index PHIEUNHAP.GHI_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PHIEUNHAP')
            and   name  = 'CUA_FK'
            and   indid > 0
            and   indid < 255)
   drop index PHIEUNHAP.CUA_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PHIEUNHAP')
            and   type = 'U')
   drop table PHIEUNHAP
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SACH')
            and   name  = 'CO_FK'
            and   indid > 0
            and   indid < 255)
   drop index SACH.CO_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SACH')
            and   type = 'U')
   drop table SACH
go

if exists (select 1
            from  sysobjects
           where  id = object_id('THELOAI')
            and   type = 'U')
   drop table THELOAI
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TRUC')
            and   name  = 'TRUC2_FK'
            and   indid > 0
            and   indid < 255)
   drop index TRUC.TRUC2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TRUC')
            and   name  = 'TRUC_FK'
            and   indid > 0
            and   indid < 255)
   drop index TRUC.TRUC_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TRUC')
            and   type = 'U')
   drop table TRUC
go

/*==============================================================*/
/* Table: BAN                                                   */
/*==============================================================*/
create table BAN (
   MASACH               int                  not null,
   STT_HD               int                  not null,
   SLB                  int                  null,
   constraint PK_BAN primary key (MASACH, STT_HD)
)
go

/*==============================================================*/
/* Index: BAN_FK                                                */
/*==============================================================*/
create index BAN_FK on BAN (
MASACH ASC
)
go

/*==============================================================*/
/* Index: BAN2_FK                                               */
/*==============================================================*/
create index BAN2_FK on BAN (
STT_HD ASC
)
go

/*==============================================================*/
/* Table: CATRUC                                                */
/*==============================================================*/
create table CATRUC (
   MACATRUC             int                  not null,
   THOIGIAN             datetime             null,
   STT                  int                  null,
   TENCATRUC            varchar(50)          null,
   constraint PK_CATRUC primary key nonclustered (MACATRUC)
)
go

/*==============================================================*/
/* Table: HOADON                                                */
/*==============================================================*/
create table HOADON (
   STT_HD               int                  not null,
   TENKH                varchar(30)          null,
   SDTKH                varchar(10)          null,
   NGAYLAP              datetime             null,
   constraint PK_HOADON primary key nonclustered (STT_HD)
)
go

/*==============================================================*/
/* Table: KESACH                                                */
/*==============================================================*/
create table KESACH (
   MAKESACH             int                  not null,
   MATL                 int                  not null,
   MANV                 int                  not null,
   TENKE                varchar(60)          null,
   constraint PK_KESACH primary key nonclustered (MAKESACH)
)
go

/*==============================================================*/
/* Index: _AT_FK                                                */
/*==============================================================*/
create index _AT_FK on KESACH (
MATL ASC
)
go

/*==============================================================*/
/* Index: QUAN_LY_FK                                            */
/*==============================================================*/
create index QUAN_LY_FK on KESACH (
MANV ASC
)
go

/*==============================================================*/
/* Table: LAP                                                   */
/*==============================================================*/
create table LAP (
   STT_HD               int                  not null,
   MANV                 int                  not null,
   constraint PK_LAP primary key (STT_HD, MANV)
)
go

/*==============================================================*/
/* Index: LAP_FK                                                */
/*==============================================================*/
create index LAP_FK on LAP (
STT_HD ASC
)
go

/*==============================================================*/
/* Index: LAP2_FK                                               */
/*==============================================================*/
create index LAP2_FK on LAP (
MANV ASC
)
go

/*==============================================================*/
/* Table: NHACUNGCAP                                            */
/*==============================================================*/
create table NHACUNGCAP (
   MANHACUNGCAP         int                  not null,
   TENNCC               varchar(30)          null,
   DIACHINCC            varchar(60)          null,
   constraint PK_NHACUNGCAP primary key nonclustered (MANHACUNGCAP)
)
go

/*==============================================================*/
/* Table: NHANVIEN                                              */
/*==============================================================*/
create table NHANVIEN (
   MANV                 int                  not null,
   TENNV                varchar(30)          null,
   DIACHINV             varchar(60)          null,
   SDTNV                varchar(10)          null,
   constraint PK_NHANVIEN primary key nonclustered (MANV)
)
go

/*==============================================================*/
/* Table: NHAP                                                  */
/*==============================================================*/
create table NHAP (
   MAPHIEUNHAP          int                  not null,
   MASACH               int                  not null,
   SOLUONGNHAP          int                  null,
   GIANHAP              float                null,
   constraint PK_NHAP primary key (MAPHIEUNHAP, MASACH)
)
go

/*==============================================================*/
/* Index: NHAP_FK                                               */
/*==============================================================*/
create index NHAP_FK on NHAP (
MAPHIEUNHAP ASC
)
go

/*==============================================================*/
/* Index: NHAP2_FK                                              */
/*==============================================================*/
create index NHAP2_FK on NHAP (
MASACH ASC
)
go

/*==============================================================*/
/* Table: PHIEUNHAP                                             */
/*==============================================================*/
create table PHIEUNHAP (
   MAPHIEUNHAP          int                  not null,
   MANV                 int                  not null,
   MANHACUNGCAP         int                  not null,
   NGAYLAPPN            datetime             null,
   DONNHAP              varchar(100)         null,
   constraint PK_PHIEUNHAP primary key nonclustered (MAPHIEUNHAP)
)
go

/*==============================================================*/
/* Index: CUA_FK                                                */
/*==============================================================*/
create index CUA_FK on PHIEUNHAP (
MANHACUNGCAP ASC
)
go

/*==============================================================*/
/* Index: GHI_FK                                                */
/*==============================================================*/
create index GHI_FK on PHIEUNHAP (
MANV ASC
)
go

/*==============================================================*/
/* Table: SACH                                                  */
/*==============================================================*/
create table SACH (
   MASACH               int                  not null,
   MATL                 int                  not null,
   TENSACH              varchar(60)          null,
   TACGIA               varchar(255)         null,
   NXB                  varchar(100)         null,
   DONGIA               money                null,
   constraint PK_SACH primary key nonclustered (MASACH)
)
go

/*==============================================================*/
/* Index: CO_FK                                                 */
/*==============================================================*/
create index CO_FK on SACH (
MATL ASC
)
go

/*==============================================================*/
/* Table: THELOAI                                               */
/*==============================================================*/
create table THELOAI (
   MATL                 int                  not null,
   TENTL                varchar(30)          null,
   constraint PK_THELOAI primary key nonclustered (MATL)
)
go

/*==============================================================*/
/* Table: TRUC                                                  */
/*==============================================================*/
create table TRUC (
   MANV                 int                  not null,
   MACATRUC             int                  not null,
   NGAYPC               datetime             null,
   constraint PK_TRUC primary key (MANV, MACATRUC)
)
go

/*==============================================================*/
/* Index: TRUC_FK                                               */
/*==============================================================*/
create index TRUC_FK on TRUC (
MANV ASC
)
go

/*==============================================================*/
/* Index: TRUC2_FK                                              */
/*==============================================================*/
create index TRUC2_FK on TRUC (
MACATRUC ASC
)
go

alter table BAN
   add constraint FK_BAN_BAN_SACH foreign key (MASACH)
      references SACH (MASACH)
go

alter table BAN
   add constraint FK_BAN_BAN2_HOADON foreign key (STT_HD)
      references HOADON (STT_HD)
go

alter table KESACH
   add constraint FK_KESACH_QUAN_LY_NHANVIEN foreign key (MANV)
      references NHANVIEN (MANV)
go

alter table KESACH
   add constraint FK_KESACH__AT_THELOAI foreign key (MATL)
      references THELOAI (MATL)
go

alter table LAP
   add constraint FK_LAP_LAP_HOADON foreign key (STT_HD)
      references HOADON (STT_HD)
go

alter table LAP
   add constraint FK_LAP_LAP2_NHANVIEN foreign key (MANV)
      references NHANVIEN (MANV)
go

alter table NHAP
   add constraint FK_NHAP_NHAP_PHIEUNHA foreign key (MAPHIEUNHAP)
      references PHIEUNHAP (MAPHIEUNHAP)
go

alter table NHAP
   add constraint FK_NHAP_NHAP2_SACH foreign key (MASACH)
      references SACH (MASACH)
go

alter table PHIEUNHAP
   add constraint FK_PHIEUNHA_CUA_NHACUNGC foreign key (MANHACUNGCAP)
      references NHACUNGCAP (MANHACUNGCAP)
go

alter table PHIEUNHAP
   add constraint FK_PHIEUNHA_GHI_NHANVIEN foreign key (MANV)
      references NHANVIEN (MANV)
go

alter table SACH
   add constraint FK_SACH_CO_THELOAI foreign key (MATL)
      references THELOAI (MATL)
go

alter table TRUC
   add constraint FK_TRUC_TRUC_NHANVIEN foreign key (MANV)
      references NHANVIEN (MANV)
go

alter table TRUC
   add constraint FK_TRUC_TRUC2_CATRUC foreign key (MACATRUC)
      references CATRUC (MACATRUC)
go

