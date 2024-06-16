WITH x AS (
    SELECT
        'Best Supper' AS MealName,
        'Best supper contains delicious entree hot gray soup and an awesome main course.' AS MealDesc
    UNION ALL
    SELECT
        'Best Brunch',
        'This is the best branch you could ever think of...'
    UNION ALL
    SELECT
        'Easy Lunch',
        '10 minute worth of preparation and you get the best meal which will give you tunzzzz of energy for the rest of the day.'
    UNION ALL
    SELECT
        'Breakfast bash',
        'Most of the delicious breakfast. You will love it!!!'
    )
UPDATE m
SET m.MealDesc = x.MealDesc
FROM Meal m
join x ON m.MealName = x.MealName;


select * from meal