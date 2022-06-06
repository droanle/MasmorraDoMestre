INSERT INTO Games ( Name, Description, Properties_List )
	VALUES (
		'AFMBE',
		'Sistema de zumbis com ambientação nos anos 80, os zumbis podem ser tanto normais com paranormais.',
		'[{ "name":"Atributos", "description":"blablabla", "abbreviation":"ATRIB"}, { "name":"Prericias", "description":"blablabla", "abbreviation":"PRER"}]'
	);

INSERT INTO Games ( Name, Description, Properties_List )
	VALUES (
		'Daemon Arkanun',
		'Sistema com magia, habilidade e poderes paranormais, combate, criaturas estranhas e múltiplas dimensões baseadas no inferno de dante.',
		'[{ "name":"Atributos", "description":"blablabla", "abbreviation":"ATRIB"}, { "name":"Prericias", "description":"blablabla", "abbreviation":"PRER"}]'
	);

INSERT INTO Games ( Name, Description, Properties_List ) 
	VALUES (
		'Dragon Age',
		'Sistema de fantasia medieval, com classes e definição de histórias bem distintas.',
		'[{ "name":"Atributos", "description":"blablabla", "abbreviation":"ATRIB"}, { "name":"Prericias", "description":"blablabla", "abbreviation":"PRER"}]'
	);


INSERT INTO SecAttributes ( Id, Name, Description, icon, Color, Owner_Fk_Id)
	VALUES (
		'PV',
		'PONTOS DE VIDA',
		'Quantidade de vida que o personagem tem.',
		'1',
		'200-10-10',
		'1'
	);

INSERT INTO SecAttributes ( Id, Name, Description, icon, Color, Owner_Fk_Id)
	VALUES (
		'PR',
		'PONTOS DE RESISTÊNCIA',
		'Capacidade de resistir do personagem.',
		'2',
		'10-200-10',
		'1'
	);

INSERT INTO SecAttributes ( Id, Name, Description, icon, Color, Owner_Fk_Id)
	VALUES (
		'AGIL',
		'AGILIDADE',
		'A agilidade do personagem.',
		'1',
		'242-242-0',
		'1'
	);

INSERT INTO Properties ( Id, Name, Roll_Formula, Usable, Owner_Fk_Id, Propertie_Type) 
	VALUES ( 
		'FOR',
		'Força',
		':D20',
		'1',
		'1',
		'ATRIB'
	);

INSERT INTO Properties ( Id, Name, Roll_Formula, Usable, Owner_Fk_Id, Propertie_Type) 
	VALUES ( 
		'DES',
		'Destreza',
		':D20',
		'1',
		'1',
		'ATRIB'
	);

INSERT INTO Properties ( Id, Name, Roll_Formula, Usable, Owner_Fk_Id, Propertie_Type) 
	VALUES ( 
		'CON',
		'Contituição',
		':D20',
		'1',
		'1',
		'ATRIB'
	);

INSERT INTO Properties ( Id, Name, Roll_Formula, Usable, Owner_Fk_Id, Propertie_Type) 
	VALUES ( 
		'INT',
		'Inteligência',
		':D20',
		'1',
		'1',
		'ATRIB'
	);

INSERT INTO Properties ( Id, Name, Roll_Formula, Usable, Owner_Fk_Id, Propertie_Type) 
	VALUES ( 
		'PER',
		'Percepção',
		':D20',
		'1',
		'1',
		'ATRIB'
	);

INSERT INTO Properties ( Id, Name, Roll_Formula, Usable, Owner_Fk_Id, Propertie_Type) 
	VALUES ( 
		'FV',
		'Força de Vontade',
		':D20',
		'1',
		'1',
		'ATRIB'
	);

INSERT INTO Properties ( Id, Name, Roll_Formula, Usable, Owner_Fk_Id, Propertie_Type) 
	VALUES ( 
		'ARMF',
		'Armas de Fogo',
		':D20',
		'1',
		'1',
		'PRER'
	);

INSERT INTO Properties ( Id, Name, Roll_Formula, Usable, Owner_Fk_Id, Propertie_Type) 
	VALUES ( 
		'ARMB',
		'Armas Brancas',
		':D20',
		'1',
		'1',
		'PRER'
	);

INSERT INTO Properties ( Id, Name, Roll_Formula, Usable, Owner_Fk_Id, Propertie_Type) 
	VALUES ( 
		'FURT',
		'Furtividade',
		':D20',
		'1',
		'1',
		'PRER'
	);

INSERT INTO Sheets ( Name, Description, Type, Image, Player, Source_Id) 
	VALUES (
		'Juliano Caetano',
		'É Chefe de Segurança, foi ex-militar e é focado e determinado.',
		'Humano',
		'Image',
		'0',
		'1'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'FOR',
		'4',
		'1'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'DES',
		'2',
		'1'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'CON',
		'4',
		'1'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'INT',
		'2',
		'1'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'PER',
		'2',
		'1'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'FV',
		'2',
		'1'
	);

INSERT INTO SecAttributesValue ( Id_Attributes, Value, Owner_Id) 
	VALUES (
		'ARMF',
		'3',
		'1'
	);

INSERT INTO SecAttributesValue ( Id_Attributes, Value, Owner_Id) 
	VALUES (
		'ARMB',
		'3',
		'1'
	);

INSERT INTO SecAttributesValue ( Id_Attributes, Value, Owner_Id) 
	VALUES (
		'FURT',
		'2',
		'1'
	);