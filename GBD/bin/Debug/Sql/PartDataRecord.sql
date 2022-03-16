show databases;

use dbspzhu;
show tables;

create table tbl_part_data_record (
	id int NOT NULL auto_increment,
    
    resultP int NOT NULL,
	
	
	
	testP0 varchar(256) NOT NULL,
	testP1 varchar(256) NOT NULL,
	testP2 varchar(256) NOT NULL,
	testP3 varchar(256) NOT NULL,
	testP4 varchar(256) NOT NULL,

	
	qrCodeP varchar(256) NOT NULL,
	
    reserved varchar(256),
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
 