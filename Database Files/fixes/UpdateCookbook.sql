WITH x AS (
    SELECT
        'Treats for two' AS BookName,
        2 AS Skill
    UNION ALL
    SELECT
        'Cook a Storm',
        3
    UNION ALL
    SELECT
        'Mom''s Kitchen',
        1
    UNION ALL
    SELECT
        'In the pot',
        1
    )
UPDATE c
SET c.Skill = x.Skill
FROM Cookbook c
join x ON c.BookName = x.BookName;


select * from cookbook