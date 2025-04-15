-- Active: 1744731682530@@mysql.codeworksacademy.com@3306@tenacious_monk_ab6d_db
CREATE TABLE chores(
  id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  name VARCHAR(255) NOT NULL,
  description VARCHAR(255),
  isComplete BOOLEAN DEFAULT false,
  isFun BOOLEAN DEFAULT false
  -- ADD YOUR OWN ADDITIONAL PROPERTIES! TRY OUT LOTS OF DIFFERENT DATA TYPES!
);

insert into chores (name, description, `isComplete`, `isFun`)
VALUES("Empty garbages", "Take out the trash and recycle bags to the trash bin", true, true), ("Clean bathrooms", "Wipe off mirrors, clean the sink", true, false),("Unload dishes", "Take the dishes out of the dishwasher and put them away", false, true),("Load dishes", "Rinse the food off and organize placing them into the dishwasher", false, false);



select * from chores;

DROP Table chores;
