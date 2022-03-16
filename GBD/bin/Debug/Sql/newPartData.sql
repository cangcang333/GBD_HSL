show databases;

use dbspzhu;
show tables;
show create table tbl_personal_account;

create table tbl_new_part_data (
	id int NOT NULL auto_increment,
    
    resultP1 int NOT NULL,
	resultP2 int NOT NULL,
	
	
	
	testP10 varchar(256) NOT NULL,
	testP11 varchar(256) NOT NULL,
	testP12 varchar(256) NOT NULL,
	testP13 varchar(256) NOT NULL,
	testP14 varchar(256) NOT NULL,
	
	testP20 varchar(256) NOT NULL,
	testP21 varchar(256) NOT NULL,
	testP22 varchar(256) NOT NULL,
	testP23 varchar(256) NOT NULL,
	testP24 varchar(256) NOT NULL,

	resultP11 int NOT NULL,
	resultP22 int NOT NULL,
	
	qrCodeP1 varchar(256) NOT NULL,
	qrCodeP2 varchar(256) NOT NULL,
	
    reserved1 varchar(256),
	created_time timestamp not null default current_timestamp,
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
 