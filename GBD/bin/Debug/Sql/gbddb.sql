


drop database gbddb ;
go
create database gbddb;
go
use gbddb;

--创建用户登录信息表
DROP TABLE tbl_gbd_user_login;
CREATE TABLE tbl_gbd_user_login (
  auto_id           int    IDENTITY(1, 1) NOT NULL,
  user_type         char(32)      NOT NULL  DEFAULT '',
  reserved          char(64)      NOT NULL  DEFAULT '',
  remark            varchar(256)  NOT NULL  DEFAULT '',
  rec_crt_ts datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  primary key(auto_id)
);
go



-- 创建焊点数据记录表
use gbddb;
DROP TABLE  tbl_gbd_workpiece_data;
CREATE TABLE tbl_gbd_workpiece_data (
  auto_id           int    IDENTITY(1, 1) NOT NULL,
  barcodeInfo       varchar(256)  NOT NULL  DEFAULT '',
  recipe_name       varchar(256)  NOT NULL  DEFAULT '',
  pieceType         int           NOT NULL,
  shellDiameter     decimal(10, 3),
  weight1           decimal(10, 3),
  perimeter1        decimal(10, 3),
  diameter1         decimal(10, 3),
  gbdValue1         decimal(10, 3),
  weight2           decimal(10, 3),
  perimeter2        decimal(10, 3),
  diameter2         decimal(10, 3),
  gbdValue2         decimal(10, 3),
  reserved          char(64)      NOT NULL  DEFAULT '',
  remark            varchar(256)  NOT NULL  DEFAULT '',
  rec_crt_ts datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  primary key(recipe_name, barcodeInfo)
);
go






