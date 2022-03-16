show databases;

use dbspzhu;
show tables;
show create table tbl_personal_account;

create table tbl_part_data (
	id int NOT NULL auto_increment,
    qr_code varchar(256) NOT NULL,
    result int NOT NULL,
    voltage decimal,
    current decimal,
    time decimal,
    reserved1 varchar(256),
    reserved2 varchar(256),
    updated_time timestamp not null default current_timestamp on update current_timestamp,
    primary key(id)
    );

 insert into tbl_part_data(result, voltage, current, time, qr_code) VALUES (0, 13.3, 88.8, 33.9, "234");
 
 
 select * from tbl_part_data;
 
 update tbl_part_data set result=0 where id=3;
 
 alter table tbl_part_data modify voltage decimal(10, 6);
 alter table tbl_part_data modify current decimal(10, 6);
 alter table tbl_part_data modify time decimal(10, 6);
 
 
SELECT * FROM tbl_part_data INTO OUTFILE 'D:\\part_data2.csv' FIELDS TERMINATED BY ',' ENCLOSED BY '"' LINES TERMINATED BY '\n';




alter table tbl_part_data add created_time timestamp not null default current_timestamp after reserved2;

show global variables like "%secure_file_priv%";
 