
/*
	This SQL script updates the ImageUrl of a specific post and the ProfilePictureUrl of a specific user in the database.
1. Choisir la nouvelle photo
Tu peux utiliser une autre photo de ton choix, par exemple une image hébergée sur un site qui fournit un lien direct.
2. Mettre à jour la photo dans SQL Server
Dans SQL Server Management Studio, exécute cette requête en remplaçant l'URL par celle de ta nouvelle image :
*/

UPDATE Posts
SET ImageUrl = 'https://images.unsplash.com/photo-1470071459604-3b5ec3a7fe05?q=80&w=1948&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=NHwxMjA3fDA%3D'
WHERE Id = 2;

UPDATE Users
SET ProfilePictureUrl = 'https://avatars.githubusercontent.com/u/20356633?v=4'
WHERE Id = 1;


--- 3. Vérifier le résultat
SELECT Id, FullName, ProfilePictureUrl
FROM Users
WHERE Id = 1;