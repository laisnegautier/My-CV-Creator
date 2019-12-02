
drop table if exists tbl_resume;
drop table if exists tbl_container;

create table tbl_resume (
	resume_id integer not null primary key auto_increment,
	resume_title varchar(100) not null,
	resume_save boolean not null,
	resume_favorite boolean not null,
	resume_last_modification datetime not null
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


create table tbl_element (
	element_id integer not null primary key auto_increment,
	container_id integer,
	container_index integer,
	FOREIGN KEY (container_id) references tbl_container(container_id)
);

create table tbl_paragraph (
	paragraph_id integer not null primary key auto_increment,
	paragraph_content varchar(100) not null,
	element_id integer,
	FOREIGN KEY (element_id) references tbl_element(element_id)
);