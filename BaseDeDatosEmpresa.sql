USE [Empresa]
GO
INSERT [Cargo] ([IDcargo], [Nombre]) VALUES (1, N'Secretario')
INSERT [Cargo] ([IDcargo], [Nombre]) VALUES (2, N'Guardia')
INSERT [Empleado] ([Cedula], [Nombre], [Apellido], [FNacimiento], [Cargo]) VALUES (12312, N'asdas', N'asd', CAST(N'2019-10-20' AS Date), 1)
