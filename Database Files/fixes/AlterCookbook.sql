alter table Cookbook add Skill INT CHECK (Skill IN (1, 2, 3))default 1
go

alter table Cookbook
add SkillDesc AS (
    CASE 
        WHEN skill = 1 THEN 'beginner'
        WHEN skill = 2 THEN 'intermediate'
        WHEN skill = 3 THEN 'advanced'
        ELSE 'unknown' 
    END)
go