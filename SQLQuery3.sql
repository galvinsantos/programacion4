SELECT procesos.id, equipos.nombre, procesos.estado, participantes.nombre, empleados.nombre, procesos.fecha
FROM procesos
INNER JOIN equipos ON procesos.idequipo = equipos.id 
INNER JOIN participantes ON procesos.idparticipante = participantes.id 
INNER JOIN empleados ON procesos.idempleado = empleados.id;