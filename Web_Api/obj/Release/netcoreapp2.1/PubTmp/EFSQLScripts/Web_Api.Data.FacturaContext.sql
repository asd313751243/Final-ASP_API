IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200324214801_MigracionInicial')
BEGIN
    CREATE TABLE [Almacenes] (
        [Id] int NOT NULL IDENTITY,
        [Nombre_Almacen] nvarchar(max) NULL,
        [Ciudad_Almacen] nvarchar(max) NULL,
        [Telefono_Almacen] int NOT NULL,
        CONSTRAINT [PK_Almacenes] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200324214801_MigracionInicial')
BEGIN
    CREATE TABLE [Almacenes_Productos] (
        [Id] int NOT NULL IDENTITY,
        [Id_Almacen] int NOT NULL,
        [Id_Producto] int NOT NULL,
        [Cantidad_Almacen_Producto] int NOT NULL,
        [Fecha_Almacen_Producto] datetime2 NOT NULL,
        CONSTRAINT [PK_Almacenes_Productos] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200324214801_MigracionInicial')
BEGIN
    CREATE TABLE [Empleados] (
        [Id] int NOT NULL IDENTITY,
        [Nombre_Empleado] int NOT NULL,
        [Sexo_Empleado] int NOT NULL,
        [Cedula_Empleado] int NOT NULL,
        [Fecha_Nac_Empleado] datetime2 NOT NULL,
        [Telefono_Empleado] int NOT NULL,
        [Usuario_Empleado] nvarchar(max) NULL,
        [Contra_Empleado] nvarchar(max) NULL,
        [Id_Fk_Sucursal] int NOT NULL,
        CONSTRAINT [PK_Empleados] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200324214801_MigracionInicial')
BEGIN
    CREATE TABLE [Empleados_Productos] (
        [Id] int NOT NULL IDENTITY,
        [Id_Empleado] int NOT NULL,
        [Id_Producto] int NOT NULL,
        [Fecha_Empleado_Producto] datetime2 NOT NULL,
        CONSTRAINT [PK_Empleados_Productos] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200324214801_MigracionInicial')
BEGIN
    CREATE TABLE [Productos] (
        [Id] int NOT NULL IDENTITY,
        [Nombre_Producto] nvarchar(max) NULL,
        [Precio_Producto] float NOT NULL,
        [Fecha_Venc_Producto] datetime2 NOT NULL,
        [Cantidad] int NOT NULL,
        CONSTRAINT [PK_Productos] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200324214801_MigracionInicial')
BEGIN
    CREATE TABLE [Sucursales] (
        [Id] int NOT NULL IDENTITY,
        [Nombre_Sucursal] nvarchar(max) NULL,
        [Ciudad_Sucursal] nvarchar(max) NULL,
        [Telefono_Sucursal] int NOT NULL,
        CONSTRAINT [PK_Sucursales] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200324214801_MigracionInicial')
BEGIN
    CREATE TABLE [Sucursales_Productos] (
        [Id] int NOT NULL IDENTITY,
        [Id_Sucursal] int NOT NULL,
        [Id_Producto] int NOT NULL,
        [Cantidad_Sucursal_Producto] int NOT NULL,
        [Fecha_Sucursal_Producto] datetime2 NOT NULL,
        CONSTRAINT [PK_Sucursales_Productos] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200324214801_MigracionInicial')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200324214801_MigracionInicial', N'2.1.8-servicing-32085');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200325014643_int-string')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Empleados]') AND [c].[name] = N'Sexo_Empleado');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Empleados] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [Empleados] ALTER COLUMN [Sexo_Empleado] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200325014643_int-string')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200325014643_int-string', N'2.1.8-servicing-32085');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200325015658_entero-a-texto')
BEGIN
    DECLARE @var1 sysname;
    SELECT @var1 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Empleados]') AND [c].[name] = N'Nombre_Empleado');
    IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Empleados] DROP CONSTRAINT [' + @var1 + '];');
    ALTER TABLE [Empleados] ALTER COLUMN [Nombre_Empleado] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200325015658_entero-a-texto')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200325015658_entero-a-texto', N'2.1.8-servicing-32085');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200326012149_Agregar-Cantidad-Empleado-Producto')
BEGIN
    ALTER TABLE [Empleados_Productos] ADD [Cantidad_Empleado_Producto] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200326012149_Agregar-Cantidad-Empleado-Producto')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200326012149_Agregar-Cantidad-Empleado-Producto', N'2.1.8-servicing-32085');
END;

GO

