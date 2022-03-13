create table Hitman(
Hitman_ID numeric(2) not null,
Hitman_Name varchar(50),
Style varchar(50),
Basic_Price numeric(4) not null,
constraint hman_pk primary key (Hitman_ID)
);

create table Target(
Target_ID numeric(2) not null,
Target_Name varchar(50) not null,
Target_Location varchar(50),
Risk numeric(3,2) not null,
constraint t_pk primary key (Target_ID)    
);
create table ExtraWish(
    Wish_ID numeric(2) not null,
    Wish varchar(50) not null,
    Extra_Price numeric(4) not null,
    constraint ew_pk primary key (Wish_ID));

create table Contract(
    Contract_ID numeric(2) not null,
    Contract_Name varchar(20),
    Hitman_ID numeric(2) not null,
    Target_ID numeric(2) not null,
    Extra_Wish_ID numeric(2),
    constraint c_pk primary key (Contract_ID),
    constraint c_fk1 foreign key (Hitman_ID) references Hitman (Hitman_ID),
    constraint c_fk2 foreign key (Target_ID) references Target (Target_ID),
    constraint c_fk3 foreign key (Extra_Wish_ID) references ExtraWish (Wish_ID)
);


