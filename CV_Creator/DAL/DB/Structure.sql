
drop table if exists tbl_resume;
drop table if exists tbl_container;


create table tbl_resume (
	resume_id integer not null primary key auto_increment,
	resume_title varchar(100) not null,
	resume_save boolean not null,
	resume_favorite boolean not null,
	resume_last_modification varchar(100) not null
);

create table tbl_container (
	container_id integer not null primary key auto_increment,
	container_name varchar(100) not null,
	container_bg_color varchar(100) not null,
	container_border_color varchar(100) not null,
	resume_id integer,
	resume_index integer,
	FOREIGN KEY (resume_id) references tbl_resume(resume_id)
);