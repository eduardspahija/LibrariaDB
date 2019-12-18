-- Krijimi i Data Dictioanry

--1

SELECT object_name, object_type 
FROM USER_OBJECTS
ORDER BY object_name;

--2

SELECT c.owner AS schema_name,
       c.table_name, 
       count(*) columns
FROM all_tab_columns c 
INNER JOIN all_tables t ON c.owner = t.owner AND c.table_name = t.table_name
WHERE c.owner = 'LIBRARIA'
GROUP BY c.owner,c.table_name
ORDER BY count(*) desc;

--3

SELECT t.owner as schema_name,
       t.table_name as table_name,
       o.created,
       o.last_ddl_time as last_modified,       
       t.num_rows,
       t.last_analyzed
FROM all_tables t
INNER JOIN all_objects o on o.owner = t.owner and o.object_name = t.table_name
WHERE t.owner = 'LIBRARIA' 
ORDER BY o.created, t.table_name;

--4

SELECT ft.owner AS table_schema_name,
       ft.table_name, 
       ft.column_name,
       pt.owner AS primary_table_schema_name,
       pt.table_name AS primary_table_name,  
       pt.column_name AS primary_table_column,
       ft.table_name || '.' || 
       ft.column_name || ' = ' || 
       pt.table_name  || '.' || 
       pt.column_name AS join_condition
FROM all_constraints c
INNER JOIN all_cons_columns ft ON ft.owner = c.owner AND ft.constraint_name = c.constraint_name
INNER JOIN all_cons_columns pt ON pt.constraint_name = c.r_constraint_name AND pt.owner = c.r_owner AND pt.position = ft.position
WHERE c.r_owner = 'LIBRARIA'    
ORDER BY ft.table_name, ft.column_name;
