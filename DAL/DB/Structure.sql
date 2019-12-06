
drop table if exists tbl_resume;
drop table if exists tbl_container;

create table tbl_resume (
	resume_id integer not null primary key auto_increment,
	resume_title varchar(100) not null,
	resume_save boolean not null,
	resume_favorite boolean not null,
	resume_creation datetime not null,
	resume_last_update datetime not null
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
	paragraph_italic boolean not null,
	paragraph_bold boolean not null,
	paragraph_size integer not null,
	paragraph_foreground_color varchar(100) not null,
	paragraph_background_color varchar(100) not null,
	element_id integer,
	FOREIGN KEY (element_id) references tbl_element(element_id)
);

create table tbl_h1 (
	h1_id integer not null primary key auto_increment,
	h1_content varchar(100) not null,
	h1_italic boolean not null,
	h1_bold boolean not null,
	h1_size integer not null,
	h1_foreground_color varchar(100) not null,
	h1_background_color varchar(100) not null,
	element_id integer,
	FOREIGN KEY (element_id) references tbl_element(element_id)
);

create table tbl_h2 (
	h2_id integer not null primary key auto_increment,
	h2_content varchar(100) not null,
	h2_italic boolean not null,
	h2_bold boolean not null,
	h2_size integer not null,
	h2_foreground_color varchar(100) not null,
	h2_background_color varchar(100) not null,
	element_id integer,
	FOREIGN KEY (element_id) references tbl_element(element_id)
);

create table tbl_date (
	date_id integer not null primary key auto_increment,
	date_content datetime not null,
	date_italic boolean not null,
	date_bold boolean not null,
	date_size integer not null,
	date_foreground_color varchar(100) not null,
	date_background_color varchar(100) not null,
	element_id integer,
	FOREIGN KEY (element_id) references tbl_element(element_id)
);