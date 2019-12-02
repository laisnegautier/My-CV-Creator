
create database if not exists bdd_projet_glog character set utf8 collate utf8_unicode_ci;
use bdd_projet_glog;

grant all privileges on bdd_projet_glog.* to 'pseudo'@'localhost' identified by 'secret';