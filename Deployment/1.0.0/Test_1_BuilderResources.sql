
DELETE FROM BuilderResources WHERE 1;
DELETE FROM BuilderResourcesCategory WHERE 1;

INSERT INTO BuilderResourcesCategory (Id, Name)
VALUES
(1, 'Mods'),
(2, 'World Edit');

INSERT INTO BuilderResources (Title, Content, CategoryId)
VALUES
('Optifine', 'Optifine Info', 1),
('Schematica', 'Schematica Info', 1),
('Command Keybinds', 'Command Keybinds Info', 1),
('World Edit Basics', 'World Edit Basics Info', 2),
('Brushes', 'Brushes Info', 2);
