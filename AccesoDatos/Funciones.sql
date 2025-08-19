-- Categorias
select * from Categorias
insert into Categorias (Nombre, Descripcion)
VALUES
    ('Operativo', 'Personal administrativo, técnico y de soporte'),
    ('Gerente', 'Personal de gestión y dirección'),
    ('Director', 'Directores de empresa');


-- Salarios 
Select * from Salarios
INSERT INTO Salarios (Monto, IdCategoria)
VALUES
(2000.00, 1), 
(4000.00, 2),  
(6000.00, 3);  


-- Tipos de Bono
select * from TipoBonos
insert into TipoBonos (Nombre)
values 
	('BonoAsistencia'), 
	('BonoHorasExtra'), 
	('BonoDesempeño'),
	('BonoMetaEquipo'),
	('BonoReduccionCostos'), 
	('BonoSatisfaccionCliente'),
	('BonoDesempeñoEmpresa'),
	('BonoCrecimientoMercado'),
	('StockOptions');

UPDATE TipoBonos
SET Monto = 1000.00
WHERE Nombre = 'BonoAsistencia';

UPDATE TipoBonos
SET Monto = 1500.00
WHERE Nombre = 'BonoHorasExtra';

UPDATE TipoBonos
SET Monto = 2000.00
WHERE Nombre = 'BonoDesempeño';

UPDATE TipoBonos
SET Monto = 1800.00
WHERE Nombre = 'BonoMetaEquipo';

UPDATE TipoBonos
SET Monto = 1200.00
WHERE Nombre = 'BonoReduccionCostos';

UPDATE TipoBonos
SET Monto = 1100.00
WHERE Nombre = 'BonoSatisfaccionCliente';

UPDATE TipoBonos
SET Monto = 2500.00
WHERE Nombre = 'BonoDesempeñoEmpresa';

UPDATE TipoBonos
SET Monto = 2200.00
WHERE Nombre = 'BonoCrecimientoMercado';

UPDATE TipoBonos
SET Monto = 3000.00
WHERE Nombre = 'StockOptions';
