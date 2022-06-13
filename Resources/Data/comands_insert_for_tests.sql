INSERT INTO Games ( Name, Description, Properties_List )
	VALUES (
		'AFMBE',
		'Sistema de zumbis com ambientação nos anos 80, os zumbis podem ser tanto normais com paranormais.',
		'{"List":[{ "name":"Atributos", "description":"blablabla", "abbreviation":"ATRIB"}, { "name":"Prericias", "description":"blablabla", "abbreviation":"PRER"}]}'
	);

INSERT INTO Games ( Name, Description, Properties_List )
	VALUES (
		'Daemon Arkanun',
		'Sistema com magia, habilidade e poderes paranormais, combate, criaturas estranhas e múltiplas dimensões baseadas no inferno de dante.',
		'{"List":[{ "name":"Atributos", "description":"blablabla", "abbreviation":"ATRIB"}, { "name":"Prericias", "description":"blablabla", "abbreviation":"PRER"}]}'
	);

INSERT INTO Games ( Name, Description, Properties_List ) 
	VALUES (
		'Dragon Age',
		'Sistema de fantasia medieval, com classes e definição de histórias bem distintas.',
		'{"List":[{ "name":"Atributos", "description":"blablabla", "abbreviation":"ATRIB"}, { "name":"Prericias", "description":"blablabla", "abbreviation":"PRER"}]}'
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
		'1',
		'0',
		'1'
	);

INSERT INTO SecAttributesValue ( Id_Attributes, Value, Owner_Id) 
	VALUES (
		'PV',
		'48/48',
		'1'
	);

INSERT INTO SecAttributesValue ( Id_Attributes, Value, Owner_Id) 
	VALUES (
		'PR',
		'35/35',
		'1'
	);

INSERT INTO SecAttributesValue ( Id_Attributes, Value, Owner_Id) 
	VALUES (
		'AGIL',
		'9/9',
		'1'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'FOR',
		'3',
		'1'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'DES',
		'3',
		'1'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'CON',
		'3',
		'1'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'INT',
		'3',
		'1'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'PER',
		'3',
		'1'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'FV',
		'3',
		'1'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'ARMF',
		'3',
		'1'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'ARMB',
		'3',
		'1'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'FURT',
		'3',
		'1'
	);

INSERT INTO Sheets ( Name, Description, Type, Image, Player, Source_Id) 
	VALUES (
		'Antonio bandeiras',
		'É Chefe de Segurança, foi ex-militar e é focado e determinado.',
		'Humano',
		'2',
		'0',
		'1'
	);

INSERT INTO SecAttributesValue ( Id_Attributes, Value, Owner_Id) 
	VALUES (
		'PV',
		'48/48',
		'2'
	);

INSERT INTO SecAttributesValue ( Id_Attributes, Value, Owner_Id) 
	VALUES (
		'PR',
		'35/35',
		'2'
	);

INSERT INTO SecAttributesValue ( Id_Attributes, Value, Owner_Id) 
	VALUES (
		'AGIL',
		'9/9',
		'2'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'FOR',
		'3',
		'2'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'DES',
		'3',
		'2'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'CON',
		'3',
		'2'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'INT',
		'3',
		'2'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'PER',
		'3',
		'2'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'FV',
		'3',
		'2'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'ARMF',
		'3',
		'2'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'ARMB',
		'3',
		'2'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'FURT',
		'3',
		'2'
	);

INSERT INTO Sheets ( Name, Description, Type, Image, Player, Source_Id) 
	VALUES (
		'Gabiru tempest',
		'É Chefe de Segurança, foi ex-militar e é focado e determinado.',
		'Humano',
		'3',
		'0',
		'1'
	);

INSERT INTO SecAttributesValue ( Id_Attributes, Value, Owner_Id) 
	VALUES (
		'PV',
		'48/48',
		'3'
	);

INSERT INTO SecAttributesValue ( Id_Attributes, Value, Owner_Id) 
	VALUES (
		'PR',
		'35/35',
		'3'
	);

INSERT INTO SecAttributesValue ( Id_Attributes, Value, Owner_Id) 
	VALUES (
		'AGIL',
		'9/9',
		'3'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'FOR',
		'3',
		'3'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'DES',
		'3',
		'3'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'CON',
		'3',
		'3'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'INT',
		'3',
		'3'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'PER',
		'3',
		'3'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'FV',
		'3',
		'3'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'ARMF',
		'3',
		'3'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'ARMB',
		'3',
		'3'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'FURT',
		'3',
		'3'
	);

INSERT INTO Sheets ( Name, Description, Type, Image, Player, Source_Id) 
	VALUES (
		'Surinami',
		'É Chefe de Segurança, foi ex-militar e é focado e determinado.',
		'Humano',
		'4',
		'0',
		'1'
	);

INSERT INTO SecAttributesValue ( Id_Attributes, Value, Owner_Id) 
	VALUES (
		'PV',
		'48/48',
		'4'
	);

INSERT INTO SecAttributesValue ( Id_Attributes, Value, Owner_Id) 
	VALUES (
		'PR',
		'35/35',
		'4'
	);

INSERT INTO SecAttributesValue ( Id_Attributes, Value, Owner_Id) 
	VALUES (
		'AGIL',
		'9/9',
		'4'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'FOR',
		'3',
		'4'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'DES',
		'3',
		'4'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'CON',
		'3',
		'4'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'INT',
		'3',
		'4'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'PER',
		'3',
		'4'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'FV',
		'3',
		'4'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'ARMF',
		'3',
		'4'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'ARMB',
		'3',
		'4'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'FURT',
		'3',
		'4'
	);

INSERT INTO Sheets ( Name, Description, Type, Image, Player, Source_Id) 
	VALUES (
		'Sucablat',
		'É Chefe de Segurança, foi ex-militar e é focado e determinado.',
		'Humano',
		'5',
		'0',
		'1'
	); 

INSERT INTO SecAttributesValue ( Id_Attributes, Value, Owner_Id) 
	VALUES (
		'PV',
		'48/48',
		'5'
	);

INSERT INTO SecAttributesValue ( Id_Attributes, Value, Owner_Id) 
	VALUES (
		'PR',
		'35/35',
		'5'
	);

INSERT INTO SecAttributesValue ( Id_Attributes, Value, Owner_Id) 
	VALUES (
		'AGIL',
		'9/9',
		'5'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'FOR',
		'3',
		'5'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'DES',
		'3',
		'5'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'CON',
		'3',
		'5'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'INT',
		'3',
		'5'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'PER',
		'3',
		'5'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'FV',
		'3',
		'5'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'ARMF',
		'3',
		'5'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'ARMB',
		'3',
		'5'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'FURT',
		'3',
		'5'
	);

INSERT INTO Sheets ( Name, Description, Type, Image, Player, Source_Id) 
	VALUES (
		'Rexona',
		'É Chefe de Segurança, foi ex-militar e é focado e determinado.',
		'Humano',
		'4',
		'0',
		'1'
	);

INSERT INTO SecAttributesValue ( Id_Attributes, Value, Owner_Id) 
	VALUES (
		'PV',
		'48/48',
		'2'
	);

INSERT INTO SecAttributesValue ( Id_Attributes, Value, Owner_Id) 
	VALUES (
		'PR',
		'35/35',
		'2'
	);

INSERT INTO SecAttributesValue ( Id_Attributes, Value, Owner_Id) 
	VALUES (
		'AGIL',
		'9/9',
		'2'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'FOR',
		'3',
		'6'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'DES',
		'3',
		'6'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'CON',
		'3',
		'6'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'INT',
		'3',
		'6'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'PER',
		'3',
		'6'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'FV',
		'3',
		'6'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'ARMF',
		'3',
		'6'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'ARMB',
		'3',
		'6'
	);

INSERT INTO PropertiesValue ( Id_Properties, Value, Owner_Id) 
	VALUES (
		'FURT',
		'3',
		'6'
	);

