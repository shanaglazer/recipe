WITH x AS (
    SELECT
        'Grilled Chicken' AS RecipeName,
        0 AS Vegan
    UNION ALL
    SELECT
        'stir-fry',
        0
    UNION ALL
    SELECT
        'Chocolate praline',
        1
    UNION ALL
    SELECT
        'falafel',
        1
	UNION ALL
    SELECT
        'Shawarma',
        0
	UNION ALL
    SELECT
        'Rice with Chili sauce',
        1
	UNION ALL
    SELECT
        'Apple Yogurt Smoothie',
        1
	UNION ALL
    SELECT
        'Butter Muffins',
        1
	UNION ALL
    SELECT
        'Cheese Bread',
        1
	UNION ALL
    SELECT
        'Chocolate Chip Cookies',
        1
    )
UPDATE r
SET r.Vegan = x.Vegan
FROM Recipe r
join x ON r.RecipeName = x.RecipeName;


select * from recipe