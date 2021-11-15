use db_smartdoctor;
GO

SET IDENTITY_INSERT [dbo].[Residencias] ON
INSERT [dbo].[Residencias] ([residenciaId], [pais]) VALUES (1, N'Colombia')
INSERT [dbo].[Residencias] ([residenciaId], [pais]) VALUES (2, N'México')
INSERT [dbo].[Residencias] ([residenciaId], [pais]) VALUES (3, N'Perú')
SET IDENTITY_INSERT [dbo].[Residencias] OFF
GO

SET IDENTITY_INSERT [dbo].[TipoPago] ON
INSERT [dbo].[TipoPago] ([tipoPagoId], [tipo]) VALUES (1, N'Otros medios de pago')
INSERT [dbo].[TipoPago] ([tipoPagoId], [tipo]) VALUES (2, N'Tengo un código de pago')
INSERT [dbo].[TipoPago] ([tipoPagoId], [tipo]) VALUES (3, N'Pagar con Tarjeta')
SET IDENTITY_INSERT [dbo].[TipoPago] OFF
GO

SET IDENTITY_INSERT [dbo].[Pacientes] ON
INSERT [dbo].[Pacientes] ([pacienteId], [nombres], [DNI], [fecha_nacimiento], [edad], [sexo], [distrito_colonia]) VALUES (1, N'Jeffersons Ledesma', N'74867428', CAST(N'1999-04-16T00:00:00.0000000' AS DateTime2), 22, 1, N'La Victoria')
SET IDENTITY_INSERT [dbo].[Pacientes] OFF
GO

SET IDENTITY_INSERT [dbo].[Especialidades] ON
INSERT [dbo].[Especialidades] ([especialidadId], [nombre], [descripcion]) VALUES (1, N'Medicina General', NULL);
INSERT [dbo].[Especialidades] ([especialidadId], [nombre], [descripcion]) VALUES (2, N'Urologia Pediátrica', NULL);
INSERT [dbo].[Especialidades] ([especialidadId], [nombre], [descripcion]) VALUES (3, N'Urología', NULL);
INSERT [dbo].[Especialidades] ([especialidadId], [nombre], [descripcion]) VALUES (4, N'Otorrinoraingología', NULL);
INSERT [dbo].[Especialidades] ([especialidadId], [nombre], [descripcion]) VALUES (5, N'Oncología', NULL);
INSERT [dbo].[Especialidades] ([especialidadId], [nombre], [descripcion]) VALUES (6, N'Oftalmología', NULL);
INSERT [dbo].[Especialidades] ([especialidadId], [nombre], [descripcion]) VALUES (7, N'Odontología', NULL);
INSERT [dbo].[Especialidades] ([especialidadId], [nombre], [descripcion]) VALUES (8, N'Neurología', NULL);
INSERT [dbo].[Especialidades] ([especialidadId], [nombre], [descripcion]) VALUES (9, N'Neumologia Pediátrica', NULL);
INSERT [dbo].[Especialidades] ([especialidadId], [nombre], [descripcion]) VALUES (10, N'Neumología', NULL);
INSERT [dbo].[Especialidades] ([especialidadId], [nombre], [descripcion]) VALUES (11, N'Medicina Interna', NULL);
INSERT [dbo].[Especialidades] ([especialidadId], [nombre], [descripcion]) VALUES (12, N'Medicina Física y Rehabilitación', NULL);
INSERT [dbo].[Especialidades] ([especialidadId], [nombre], [descripcion]) VALUES (13, N'Medicina Familiar y Comunitaria', NULL);
INSERT [dbo].[Especialidades] ([especialidadId], [nombre], [descripcion]) VALUES (14, N'Hermatología', NULL);
INSERT [dbo].[Especialidades] ([especialidadId], [nombre], [descripcion]) VALUES (15, N'Ginecología', NULL);
INSERT [dbo].[Especialidades] ([especialidadId], [nombre], [descripcion]) VALUES (16, N'Geriatría', NULL);
INSERT [dbo].[Especialidades] ([especialidadId], [nombre], [descripcion]) VALUES (17, N'Gestroenterología', NULL);
INSERT [dbo].[Especialidades] ([especialidadId], [nombre], [descripcion]) VALUES (18, N'Fisioterapia', NULL);
INSERT [dbo].[Especialidades] ([especialidadId], [nombre], [descripcion]) VALUES (19, N'Endocrinologia Pediátrica', NULL);
INSERT [dbo].[Especialidades] ([especialidadId], [nombre], [descripcion]) VALUES (20, N'Dermatología', NULL);
INSERT [dbo].[Especialidades] ([especialidadId], [nombre], [descripcion]) VALUES (21, N'Cirugia General', NULL);
INSERT [dbo].[Especialidades] ([especialidadId], [nombre], [descripcion]) VALUES (22, N'Cardiología', NULL);
INSERT [dbo].[Especialidades] ([especialidadId], [nombre], [descripcion]) VALUES (23, N'Reumatología', NULL);
INSERT [dbo].[Especialidades] ([especialidadId], [nombre], [descripcion]) VALUES (24, N'Nutrición', NULL);
INSERT [dbo].[Especialidades] ([especialidadId], [nombre], [descripcion]) VALUES (25, N'Endocrinología', NULL);
INSERT [dbo].[Especialidades] ([especialidadId], [nombre], [descripcion]) VALUES (26, N'Pediatría', NULL);
INSERT [dbo].[Especialidades] ([especialidadId], [nombre], [descripcion]) VALUES (27, N'Psiquiatría', NULL);
INSERT [dbo].[Especialidades] ([especialidadId], [nombre], [descripcion]) VALUES (28, N'Psicología', NULL);
INSERT [dbo].[Especialidades] ([especialidadId], [nombre], [descripcion]) VALUES (29, N'Gestroenterologia Pediátrica', NULL);
INSERT [dbo].[Especialidades] ([especialidadId], [nombre], [descripcion]) VALUES (30, N'Neurocirugía', NULL);
SET IDENTITY_INSERT [dbo].[Especialidades] OFF
GO

SET IDENTITY_INSERT [dbo].[Medicos] ON
INSERT [dbo].[Medicos] ([medicoId], [especialidadId], [residenciaId], [nombres], [CMP], [celular], [correo], [descripcion]) VALUES (1, 24, 3, N'Valia Aparicio', N'763826', N'965738261', N'valia@hotmail.com', N'Enfermedades cronicas (diabetes, dislipidemias, hta) Obesidad, gastritis, nutrición para aumento de peso o masa muscular.');
INSERT [dbo].[Medicos] ([medicoId], [especialidadId], [residenciaId], [nombres], [CMP], [celular], [correo], [descripcion]) VALUES (2, 1, 3, N'Cindy Benites', N'567243', N'965384521', N'cbenites@hotmail.com', N'Enfermedades cronicas no transmitibles como hipertension arterial, diabetes mellitus y sus complicaciones (Insuficiencia renal cronica con o sin diálisis).');
INSERT [dbo].[Medicos] ([medicoId], [especialidadId], [residenciaId], [nombres], [CMP], [celular], [correo], [descripcion]) VALUES (3, 24, 3, N'Cindy Castro', N'675281', N'967546281', N'ccastro@hotmail.com', N'Sobreoeso, obesidad, diabetes, dislipedimias, hipertensión, entre otros.');
INSERT [dbo].[Medicos] ([medicoId], [especialidadId], [residenciaId], [nombres], [CMP], [celular], [correo], [descripcion]) VALUES (4, 1, 3, N'Petrolina Castro', N'847221', N'993672182', N'pcastro@hotmail.com', N'Atención Integral en Salud - Problemas médicos en general - Enfermedades transmitibles - Enfermedades crónicas no transmitibles - Salud Mental - Lenguaje de señas para sordomudos.');
INSERT [dbo].[Medicos] ([medicoId], [especialidadId], [residenciaId], [nombres], [CMP], [celular], [correo], [descripcion]) VALUES (5, 28, 3, N'Abraham Deus', N'765301', N'996378213', N'adeus@hotmail.com', N'Abordaje psicoterapéutico del Duelo Migratorio Psicoterapia Infantil y Juvenil, Terapia ABA para el abordaje de niños con Autismo. TDAH Sindrome de Down, Psicoterapia del adulto. Terapia centrada en el logro de objetivos y metas, fortalecimiento del autoestima y autoconcepto.');
INSERT [dbo].[Medicos] ([medicoId], [especialidadId], [residenciaId], [nombres], [CMP], [celular], [correo], [descripcion]) VALUES (6, 20, 3, N'Monica Gutierrez Cruz', N'736293', N'987674231', N'mcruz@hotmail.com', N'Dermatología clínica, estética y láser.')
SET IDENTITY_INSERT [dbo].[Medicos] OFF
GO

SET IDENTITY_INSERT [dbo].[Estudios] ON
INSERT [dbo].[Estudios] ([estudioId], [medicoId], [descripcion], [anio]) VALUES (1, 1, N'Medicina Humana - UPAO', 2019);
INSERT [dbo].[Estudios] ([estudioId], [medicoId], [descripcion], [anio]) VALUES (2, 1, N'Diplomado en Salud Ocupacional', 2020);
INSERT [dbo].[Estudios] ([estudioId], [medicoId], [descripcion], [anio]) VALUES (3, 2, N'Medicina Humana - UPAO', 2014);
INSERT [dbo].[Estudios] ([estudioId], [medicoId], [descripcion], [anio]) VALUES (4, 2, N'Postgrado: Maestria en Gestión de los servicios de salud - Univ. Nac. Tumbes', 2021);
INSERT [dbo].[Estudios] ([estudioId], [medicoId], [descripcion], [anio]) VALUES (5, 3, N'Postgrado: UCSUR - Medicina Humana', 2018);
INSERT [dbo].[Estudios] ([estudioId], [medicoId], [descripcion], [anio]) VALUES (6, 3, N'Postgrado: UNSLG - Diplomado en Salud Ocupacional y del Medio Ambiente - Ica', 2019);
INSERT [dbo].[Estudios] ([estudioId], [medicoId], [descripcion], [anio]) VALUES (7, 3, N'UCSUR - Diplomado en Auditoría Medica', 2020);
INSERT [dbo].[Estudios] ([estudioId], [medicoId], [descripcion], [anio]) VALUES (8, 4, N'Pregrado: Medicina Humana - UNSLG de Ica', 1987);
INSERT [dbo].[Estudios] ([estudioId], [medicoId], [descripcion], [anio]) VALUES (9, 4, N'Postgrado: Mestría en Salud Pública estudios concluidos sin título', 2013);
INSERT [dbo].[Estudios] ([estudioId], [medicoId], [descripcion], [anio]) VALUES (10, 5, N'Medicina Humana - UNPRG', 2001);
INSERT [dbo].[Estudios] ([estudioId], [medicoId], [descripcion], [anio]) VALUES (11, 6, N'Pregrado en la Universidad de Stávropol - Rusia', 2005);
INSERT [dbo].[Estudios] ([estudioId], [medicoId], [descripcion], [anio]) VALUES (12, 6, N'Diplomado en Diabetes', 2010);
INSERT [dbo].[Estudios] ([estudioId], [medicoId], [descripcion], [anio]) VALUES (13, 6, N'Maestría en Gestión de Salud', 2016);
SET IDENTITY_INSERT [dbo].[Estudios] OFF
GO


SET IDENTITY_INSERT [dbo].[Experiencias] ON
INSERT [dbo].[Experiencias] ([experienciaId], [medicoId], [descripcion], [anio]) VALUES (1, 1, N'Centro de Salud Huarisca en Huancayo', 1998);
INSERT [dbo].[Experiencias] ([experienciaId], [medicoId], [descripcion], [anio]) VALUES (2, 1, N'Centro de Salud fortaleza', 2007);
INSERT [dbo].[Experiencias] ([experienciaId], [medicoId], [descripcion], [anio]) VALUES (3, 1, N'CMI Sta. Luzmila IL - Ate Vitarte', 2021);
INSERT [dbo].[Experiencias] ([experienciaId], [medicoId], [descripcion], [anio]) VALUES (4, 2, N'Hospital essalud de Tumbes-med. PADOMI', 2020);
INSERT [dbo].[Experiencias] ([experienciaId], [medicoId], [descripcion], [anio]) VALUES (5, 2, N'Instituto de Medicina Legal-med.legista', 2016);
INSERT [dbo].[Experiencias] ([experienciaId], [medicoId], [descripcion], [anio]) VALUES (6, 2, N'Clinica de hemodialisis salud renal - Médico general', 2017);
INSERT [dbo].[Experiencias] ([experienciaId], [medicoId], [descripcion], [anio]) VALUES (7, 2, N'Clinica nefro salud - Medicina General', 2015);
INSERT [dbo].[Experiencias] ([experienciaId], [medicoId], [descripcion], [anio]) VALUES (8, 3, N'Medico Asistente I Nivel de Atención en Red de Salud - Ica', 1991);
INSERT [dbo].[Experiencias] ([experienciaId], [medicoId], [descripcion], [anio]) VALUES (9, 3, N'Facultad de Medicina Humana de UNSLG - Ica', 2007);
INSERT [dbo].[Experiencias] ([experienciaId], [medicoId], [descripcion], [anio]) VALUES (10, 3, N'Docente en Facultad de Medicina Humana de UPSJB', 2017);
INSERT [dbo].[Experiencias] ([experienciaId], [medicoId], [descripcion], [anio]) VALUES (11, 3, N'Médico Asistente en I Nivel - Huancavelica', 1989);
INSERT [dbo].[Experiencias] ([experienciaId], [medicoId], [descripcion], [anio]) VALUES (12, 4, N'Centro de Salud Huarisca en Huancayo', 1998);
INSERT [dbo].[Experiencias] ([experienciaId], [medicoId], [descripcion], [anio]) VALUES (13, 4, N'Centro de salud Fortaleza', 2000);
INSERT [dbo].[Experiencias] ([experienciaId], [medicoId], [descripcion], [anio]) VALUES (14, 4, N'CMI Sta. Luzmila IL - Ate Vitarte', 2005);
INSERT [dbo].[Experiencias] ([experienciaId], [medicoId], [descripcion], [anio]) VALUES (15, 5, N'Hospital Carlos Lanfranco La Hoz', 2019);
INSERT [dbo].[Experiencias] ([experienciaId], [medicoId], [descripcion], [anio]) VALUES (16, 5, N'C.S Ahuayro', 2020);
INSERT [dbo].[Experiencias] ([experienciaId], [medicoId], [descripcion], [anio]) VALUES (17, 6, N'CAP II Tayaramba ESSALUD - Medico Asistencial', 2020);
SET IDENTITY_INSERT [dbo].[Experiencias] OFF
GO

SET IDENTITY_INSERT [dbo].[Consultorios] ON
INSERT [dbo].[Consultorios] ([consultorioId], [medicoId], [importe], [duracion]) VALUES (1, 1, 80, 45);
INSERT [dbo].[Consultorios] ([consultorioId], [medicoId], [importe], [duracion]) VALUES (2, 2, 40, 15);
INSERT [dbo].[Consultorios] ([consultorioId], [medicoId], [importe], [duracion]) VALUES (3, 3, 30, 20);
INSERT [dbo].[Consultorios] ([consultorioId], [medicoId], [importe], [duracion]) VALUES (4, 4, 60, 45);
INSERT [dbo].[Consultorios] ([consultorioId], [medicoId], [importe], [duracion]) VALUES (5, 5, 70, 30);
INSERT [dbo].[Consultorios] ([consultorioId], [medicoId], [importe], [duracion]) VALUES (6, 6, 50, 20);
SET IDENTITY_INSERT [dbo].[Consultorios] OFF
GO

SET IDENTITY_INSERT [dbo].[Horarios] ON
INSERT [dbo].[Horarios] ([horarioId], [medicoId], [fecha], [hora_inicio], [hora_fin], [disponible]) VALUES (1, 1, CAST(N'2021-11-17T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-17T08:00:00.0000000' AS DateTime2), CAST(N'2021-11-17T08:45:00.0000000' AS DateTime2), 1);
INSERT [dbo].[Horarios] ([horarioId], [medicoId], [fecha], [hora_inicio], [hora_fin], [disponible]) VALUES (2, 1, CAST(N'2021-11-17T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-17T08:45:00.0000000' AS DateTime2), CAST(N'2021-11-17T09:30:00.0000000' AS DateTime2), 1);
INSERT [dbo].[Horarios] ([horarioId], [medicoId], [fecha], [hora_inicio], [hora_fin], [disponible]) VALUES (3, 1, CAST(N'2021-11-17T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-17T09:30:00.0000000' AS DateTime2), CAST(N'2021-11-17T10:15:00.0000000' AS DateTime2), 1);
INSERT [dbo].[Horarios] ([horarioId], [medicoId], [fecha], [hora_inicio], [hora_fin], [disponible]) VALUES (4, 1, CAST(N'2021-11-17T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-17T10:15:00.0000000' AS DateTime2), CAST(N'2021-11-17T11:00:00.0000000' AS DateTime2), 1);
INSERT [dbo].[Horarios] ([horarioId], [medicoId], [fecha], [hora_inicio], [hora_fin], [disponible]) VALUES (5, 2, CAST(N'2021-11-16T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-16T12:00:00.0000000' AS DateTime2), CAST(N'2021-11-16T12:15:00.0000000' AS DateTime2), 1);
INSERT [dbo].[Horarios] ([horarioId], [medicoId], [fecha], [hora_inicio], [hora_fin], [disponible]) VALUES (6, 2, CAST(N'2021-11-16T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-16T12:15:00.0000000' AS DateTime2), CAST(N'2021-11-16T12:30:00.0000000' AS DateTime2), 1);
INSERT [dbo].[Horarios] ([horarioId], [medicoId], [fecha], [hora_inicio], [hora_fin], [disponible]) VALUES (7, 2, CAST(N'2021-11-16T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-16T12:30:00.0000000' AS DateTime2), CAST(N'2021-11-16T12:45:00.0000000' AS DateTime2), 1);
INSERT [dbo].[Horarios] ([horarioId], [medicoId], [fecha], [hora_inicio], [hora_fin], [disponible]) VALUES (8, 2, CAST(N'2021-11-16T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-16T18:00:00.0000000' AS DateTime2), CAST(N'2021-11-16T18:15:00.0000000' AS DateTime2), 1);
INSERT [dbo].[Horarios] ([horarioId], [medicoId], [fecha], [hora_inicio], [hora_fin], [disponible]) VALUES (9, 2, CAST(N'2021-11-16T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-16T18:15:00.0000000' AS DateTime2), CAST(N'2021-11-16T18:30:00.0000000' AS DateTime2), 1);
INSERT [dbo].[Horarios] ([horarioId], [medicoId], [fecha], [hora_inicio], [hora_fin], [disponible]) VALUES (10, 2, CAST(N'2021-11-16T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-16T18:30:00.0000000' AS DateTime2), CAST(N'2021-11-16T18:45:00.0000000' AS DateTime2), 1);
INSERT [dbo].[Horarios] ([horarioId], [medicoId], [fecha], [hora_inicio], [hora_fin], [disponible]) VALUES (11, 2, CAST(N'2021-11-16T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-16T18:45:00.0000000' AS DateTime2), CAST(N'2021-11-16T19:00:00.0000000' AS DateTime2), 1);
INSERT [dbo].[Horarios] ([horarioId], [medicoId], [fecha], [hora_inicio], [hora_fin], [disponible]) VALUES (12, 3, CAST(N'2021-11-17T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-17T08:00:00.0000000' AS DateTime2), CAST(N'2021-11-17T08:20:00.0000000' AS DateTime2), 1);
INSERT [dbo].[Horarios] ([horarioId], [medicoId], [fecha], [hora_inicio], [hora_fin], [disponible]) VALUES (13, 3, CAST(N'2021-11-17T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-17T08:20:00.0000000' AS DateTime2), CAST(N'2021-11-17T08:40:00.0000000' AS DateTime2), 1);
INSERT [dbo].[Horarios] ([horarioId], [medicoId], [fecha], [hora_inicio], [hora_fin], [disponible]) VALUES (14, 3, CAST(N'2021-11-17T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-17T08:40:00.0000000' AS DateTime2), CAST(N'2021-11-17T09:00:00.0000000' AS DateTime2), 1);
INSERT [dbo].[Horarios] ([horarioId], [medicoId], [fecha], [hora_inicio], [hora_fin], [disponible]) VALUES (15, 3, CAST(N'2021-11-17T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-17T09:00:00.0000000' AS DateTime2), CAST(N'2021-11-17T09:20:00.0000000' AS DateTime2), 1);
INSERT [dbo].[Horarios] ([horarioId], [medicoId], [fecha], [hora_inicio], [hora_fin], [disponible]) VALUES (16, 3, CAST(N'2021-11-17T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-17T09:20:00.0000000' AS DateTime2), CAST(N'2021-11-17T09:40:00.0000000' AS DateTime2), 1);
INSERT [dbo].[Horarios] ([horarioId], [medicoId], [fecha], [hora_inicio], [hora_fin], [disponible]) VALUES (17, 3, CAST(N'2021-11-17T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-17T09:40:00.0000000' AS DateTime2), CAST(N'2021-11-17T10:00:00.0000000' AS DateTime2), 1);
INSERT [dbo].[Horarios] ([horarioId], [medicoId], [fecha], [hora_inicio], [hora_fin], [disponible]) VALUES (18, 3, CAST(N'2021-11-17T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-17T10:00:00.0000000' AS DateTime2), CAST(N'2021-11-17T10:20:00.0000000' AS DateTime2), 1);
INSERT [dbo].[Horarios] ([horarioId], [medicoId], [fecha], [hora_inicio], [hora_fin], [disponible]) VALUES (19, 3, CAST(N'2021-11-17T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-17T10:20:00.0000000' AS DateTime2), CAST(N'2021-11-17T10:40:00.0000000' AS DateTime2), 1);
INSERT [dbo].[Horarios] ([horarioId], [medicoId], [fecha], [hora_inicio], [hora_fin], [disponible]) VALUES (20, 3, CAST(N'2021-11-17T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-17T10:40:00.0000000' AS DateTime2), CAST(N'2021-11-17T11:00:00.0000000' AS DateTime2), 1);
INSERT [dbo].[Horarios] ([horarioId], [medicoId], [fecha], [hora_inicio], [hora_fin], [disponible]) VALUES (21, 4, CAST(N'2021-11-18T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-18T10:00:00.0000000' AS DateTime2), CAST(N'2021-11-18T10:45:00.0000000' AS DateTime2), 1);
INSERT [dbo].[Horarios] ([horarioId], [medicoId], [fecha], [hora_inicio], [hora_fin], [disponible]) VALUES (22, 4, CAST(N'2021-11-18T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-18T10:45:00.0000000' AS DateTime2), CAST(N'2021-11-18T11:30:00.0000000' AS DateTime2), 1);
INSERT [dbo].[Horarios] ([horarioId], [medicoId], [fecha], [hora_inicio], [hora_fin], [disponible]) VALUES (23, 4, CAST(N'2021-11-18T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-18T11:30:00.0000000' AS DateTime2), CAST(N'2021-11-18T12:15:00.0000000' AS DateTime2), 1);
INSERT [dbo].[Horarios] ([horarioId], [medicoId], [fecha], [hora_inicio], [hora_fin], [disponible]) VALUES (24, 5, CAST(N'2021-11-18T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-18T08:00:00.0000000' AS DateTime2), CAST(N'2021-11-18T08:30:00.0000000' AS DateTime2), 1);
INSERT [dbo].[Horarios] ([horarioId], [medicoId], [fecha], [hora_inicio], [hora_fin], [disponible]) VALUES (25, 5, CAST(N'2021-11-18T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-18T08:30:00.0000000' AS DateTime2), CAST(N'2021-11-18T09:00:00.0000000' AS DateTime2), 1);
INSERT [dbo].[Horarios] ([horarioId], [medicoId], [fecha], [hora_inicio], [hora_fin], [disponible]) VALUES (26, 5, CAST(N'2021-11-18T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-18T09:00:00.0000000' AS DateTime2), CAST(N'2021-11-18T09:30:00.0000000' AS DateTime2), 1);
INSERT [dbo].[Horarios] ([horarioId], [medicoId], [fecha], [hora_inicio], [hora_fin], [disponible]) VALUES (27, 5, CAST(N'2021-11-18T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-18T09:30:00.0000000' AS DateTime2), CAST(N'2021-11-18T10:00:00.0000000' AS DateTime2), 1);
INSERT [dbo].[Horarios] ([horarioId], [medicoId], [fecha], [hora_inicio], [hora_fin], [disponible]) VALUES (28, 5, CAST(N'2021-11-18T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-18T10:00:00.0000000' AS DateTime2), CAST(N'2021-11-18T10:30:00.0000000' AS DateTime2), 1);
INSERT [dbo].[Horarios] ([horarioId], [medicoId], [fecha], [hora_inicio], [hora_fin], [disponible]) VALUES (29, 5, CAST(N'2021-11-18T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-18T10:30:00.0000000' AS DateTime2), CAST(N'2021-11-18T11:00:00.0000000' AS DateTime2), 1);
INSERT [dbo].[Horarios] ([horarioId], [medicoId], [fecha], [hora_inicio], [hora_fin], [disponible]) VALUES (30, 6, CAST(N'2021-11-18T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-18T15:00:00.0000000' AS DateTime2), CAST(N'2021-11-18T15:20:00.0000000' AS DateTime2), 1);
INSERT [dbo].[Horarios] ([horarioId], [medicoId], [fecha], [hora_inicio], [hora_fin], [disponible]) VALUES (31, 6, CAST(N'2021-11-18T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-18T15:20:00.0000000' AS DateTime2), CAST(N'2021-11-18T15:40:00.0000000' AS DateTime2), 1);
INSERT [dbo].[Horarios] ([horarioId], [medicoId], [fecha], [hora_inicio], [hora_fin], [disponible]) VALUES (32, 6, CAST(N'2021-11-18T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-18T15:40:00.0000000' AS DateTime2), CAST(N'2021-11-18T16:00:00.0000000' AS DateTime2), 1);
INSERT [dbo].[Horarios] ([horarioId], [medicoId], [fecha], [hora_inicio], [hora_fin], [disponible]) VALUES (33, 6, CAST(N'2021-11-18T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-18T16:00:00.0000000' AS DateTime2), CAST(N'2021-11-18T16:20:00.0000000' AS DateTime2), 1);
INSERT [dbo].[Horarios] ([horarioId], [medicoId], [fecha], [hora_inicio], [hora_fin], [disponible]) VALUES (34, 6, CAST(N'2021-11-18T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-18T16:20:00.0000000' AS DateTime2), CAST(N'2021-11-18T16:40:00.0000000' AS DateTime2), 1);
INSERT [dbo].[Horarios] ([horarioId], [medicoId], [fecha], [hora_inicio], [hora_fin], [disponible]) VALUES (35, 6, CAST(N'2021-11-18T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-18T16:40:00.0000000' AS DateTime2), CAST(N'2021-11-18T17:00:00.0000000' AS DateTime2), 1);
INSERT [dbo].[Horarios] ([horarioId], [medicoId], [fecha], [hora_inicio], [hora_fin], [disponible]) VALUES (36, 6, CAST(N'2021-11-18T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-18T17:00:00.0000000' AS DateTime2), CAST(N'2021-11-18T17:20:00.0000000' AS DateTime2), 1);
INSERT [dbo].[Horarios] ([horarioId], [medicoId], [fecha], [hora_inicio], [hora_fin], [disponible]) VALUES (37, 6, CAST(N'2021-11-18T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-18T17:20:00.0000000' AS DateTime2), CAST(N'2021-11-18T17:40:00.0000000' AS DateTime2), 1);
INSERT [dbo].[Horarios] ([horarioId], [medicoId], [fecha], [hora_inicio], [hora_fin], [disponible]) VALUES (38, 6, CAST(N'2021-11-18T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-18T17:40:00.0000000' AS DateTime2), CAST(N'2021-11-18T18:00:00.0000000' AS DateTime2), 1);
INSERT [dbo].[Horarios] ([horarioId], [medicoId], [fecha], [hora_inicio], [hora_fin], [disponible]) VALUES (39, 6, CAST(N'2021-11-18T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-18T18:00:00.0000000' AS DateTime2), CAST(N'2021-11-18T18:20:00.0000000' AS DateTime2), 1);
INSERT [dbo].[Horarios] ([horarioId], [medicoId], [fecha], [hora_inicio], [hora_fin], [disponible]) VALUES (40, 6, CAST(N'2021-11-19T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-19T08:00:00.0000000' AS DateTime2), CAST(N'2021-11-19T08:20:00.0000000' AS DateTime2), 1);
INSERT [dbo].[Horarios] ([horarioId], [medicoId], [fecha], [hora_inicio], [hora_fin], [disponible]) VALUES (41, 6, CAST(N'2021-11-19T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-19T08:20:00.0000000' AS DateTime2), CAST(N'2021-11-19T08:40:00.0000000' AS DateTime2), 1);
INSERT [dbo].[Horarios] ([horarioId], [medicoId], [fecha], [hora_inicio], [hora_fin], [disponible]) VALUES (42, 6, CAST(N'2021-11-19T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-19T08:40:00.0000000' AS DateTime2), CAST(N'2021-11-19T09:00:00.0000000' AS DateTime2), 1);
INSERT [dbo].[Horarios] ([horarioId], [medicoId], [fecha], [hora_inicio], [hora_fin], [disponible]) VALUES (43, 6, CAST(N'2021-11-19T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-19T09:00:00.0000000' AS DateTime2), CAST(N'2021-11-19T09:20:00.0000000' AS DateTime2), 1);
SET IDENTITY_INSERT [dbo].[Horarios] OFF
GO

SET IDENTITY_INSERT [dbo].[Citas] ON 
INSERT [dbo].[Citas] ([citaId], [medicoId], [pacienteId], [fecha], [hora_inicio], [hora_fin], [motivo], [costo], [pagado], [atendido], [fecha_registro]) VALUES (1, 1, 1, CAST(N'2021-11-17T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-17T08:00:00.0000000' AS DateTime2), CAST(N'2021-11-17T08:45:00.0000000' AS DateTime2), N'Dolor de cabeza', 80, 0, 0, CAST(N'2021-11-14T21:49:21.4390438' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Citas] OFF
GO