-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Servidor: localhost
-- Tiempo de generación: 24-10-2019 a las 21:49:54
-- Versión del servidor: 5.7.17-log
-- Versión de PHP: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `gimnasio`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `aparato`
--

CREATE TABLE `aparato` (
  `id_aparatos` int(4) NOT NULL,
  `aparato` varchar(80) NOT NULL,
  `detalle` varchar(400) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `aparato`
--

INSERT INTO `aparato` (`id_aparatos`, `aparato`, `detalle`) VALUES
(1, 'bici', 'es una bici');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

CREATE TABLE `cliente` (
  `id_cliente` int(4) NOT NULL,
  `nombre` char(20) DEFAULT NULL,
  `apellido` char(20) DEFAULT NULL,
  `dni` int(11) NOT NULL,
  `telefono` int(11) NOT NULL,
  `ciudad` char(20) NOT NULL,
  `fechanac` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `sexo` char(20) NOT NULL,
  `id_modalidad` int(4) NOT NULL,
  `id_rutina` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `cliente`
--

INSERT INTO `cliente` (`id_cliente`, `nombre`, `apellido`, `dni`, `telefono`, `ciudad`, `fechanac`, `sexo`, `id_modalidad`, `id_rutina`) VALUES
(0, 'j', 'c', 300, 22, 'chaca', '2019-09-10 03:00:00', 'Femenino', 0, 0),
(1, 'juan', 'cape', 2334, 3355, 'chaca', '2019-10-15 03:00:00', 'Masculino', 0, 0),
(6, 'g', 'b', 6, 77, 'k', '2019-08-26 03:00:00', 'Femenino', 0, 0),
(7, 'juan', 'cape', 239, 3423, 'ddd', '2019-08-26 03:00:00', 'Masculino', 0, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cuota`
--

CREATE TABLE `cuota` (
  `id_cuota` int(11) NOT NULL,
  `anio` int(4) NOT NULL,
  `mes` int(2) NOT NULL,
  `fecha` datetime NOT NULL,
  `precio` decimal(65,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `cuota`
--

INSERT INTO `cuota` (`id_cuota`, `anio`, `mes`, `fecha`, `precio`) VALUES
(1, 2019, 11, '2019-09-10 00:00:00', '200.00');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `gastos`
--

CREATE TABLE `gastos` (
  `fecha` datetime NOT NULL,
  `id_gastos` int(4) NOT NULL,
  `detalle` varchar(400) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `gastos`
--

INSERT INTO `gastos` (`fecha`, `id_gastos`, `detalle`) VALUES
('2019-10-23 00:00:00', 1, 'mate y termo');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `modalidad`
--

CREATE TABLE `modalidad` (
  `detalle` varchar(400) NOT NULL,
  `monto` decimal(10,0) NOT NULL,
  `id_modalidad` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `modalidad`
--

INSERT INTO `modalidad` (`detalle`, `monto`, `id_modalidad`) VALUES
('de todo', '10', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pago`
--

CREATE TABLE `pago` (
  `id_cliente` int(4) NOT NULL,
  `id_cuota` int(4) NOT NULL,
  `fecha` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `pago`
--

INSERT INTO `pago` (`id_cliente`, `id_cuota`, `fecha`) VALUES
(0, 1, '2019-10-23 00:00:00');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `profesor`
--

CREATE TABLE `profesor` (
  `id_profesor` int(4) NOT NULL,
  `nombre` varchar(60) NOT NULL,
  `apellido` varchar(60) NOT NULL,
  `documento` int(20) NOT NULL,
  `celular` varchar(20) NOT NULL,
  `ciudad` varchar(20) NOT NULL,
  `id_sueldo` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `profesor`
--

INSERT INTO `profesor` (`id_profesor`, `nombre`, `apellido`, `documento`, `celular`, `ciudad`, `id_sueldo`) VALUES
(1, 'Juan', 'Pedro', 0, '', '', 2000);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `rutina`
--

CREATE TABLE `rutina` (
  `id_rutina` int(4) NOT NULL,
  `detalle` varchar(400) NOT NULL,
  `id_aparatos` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `rutina`
--

INSERT INTO `rutina` (`id_rutina`, `detalle`, `id_aparatos`) VALUES
(0, '10 minutos', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `rutina_profesor`
--

CREATE TABLE `rutina_profesor` (
  `id_rutina` int(4) NOT NULL,
  `id_profesor` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `sueldo`
--

CREATE TABLE `sueldo` (
  `id_sueldo` int(4) NOT NULL,
  `sueldo` decimal(10,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `aparato`
--
ALTER TABLE `aparato`
  ADD PRIMARY KEY (`id_aparatos`);

--
-- Indices de la tabla `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`id_cliente`),
  ADD KEY `id_rutina` (`id_rutina`),
  ADD KEY `id_modalidad` (`id_modalidad`);

--
-- Indices de la tabla `cuota`
--
ALTER TABLE `cuota`
  ADD PRIMARY KEY (`id_cuota`);

--
-- Indices de la tabla `gastos`
--
ALTER TABLE `gastos`
  ADD PRIMARY KEY (`id_gastos`);

--
-- Indices de la tabla `modalidad`
--
ALTER TABLE `modalidad`
  ADD PRIMARY KEY (`id_modalidad`);

--
-- Indices de la tabla `pago`
--
ALTER TABLE `pago`
  ADD PRIMARY KEY (`id_cliente`,`id_cuota`),
  ADD KEY `id_cuota` (`id_cuota`);

--
-- Indices de la tabla `profesor`
--
ALTER TABLE `profesor`
  ADD PRIMARY KEY (`id_profesor`),
  ADD UNIQUE KEY `id_sueldo` (`id_sueldo`),
  ADD KEY `id_sueldo_2` (`id_sueldo`);

--
-- Indices de la tabla `rutina`
--
ALTER TABLE `rutina`
  ADD PRIMARY KEY (`id_rutina`),
  ADD KEY `id_aparatos` (`id_aparatos`);

--
-- Indices de la tabla `rutina_profesor`
--
ALTER TABLE `rutina_profesor`
  ADD PRIMARY KEY (`id_rutina`,`id_profesor`),
  ADD KEY `id_profesor` (`id_profesor`);

--
-- Indices de la tabla `sueldo`
--
ALTER TABLE `sueldo`
  ADD PRIMARY KEY (`id_sueldo`);

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `cliente`
--
ALTER TABLE `cliente`
  ADD CONSTRAINT `cliente_ibfk_2` FOREIGN KEY (`id_modalidad`) REFERENCES `modalidad` (`id_modalidad`),
  ADD CONSTRAINT `cliente_ibfk_3` FOREIGN KEY (`id_rutina`) REFERENCES `rutina` (`id_rutina`);

--
-- Filtros para la tabla `pago`
--
ALTER TABLE `pago`
  ADD CONSTRAINT `pago_ibfk_1` FOREIGN KEY (`id_cuota`) REFERENCES `cuota` (`id_cuota`),
  ADD CONSTRAINT `pago_ibfk_2` FOREIGN KEY (`id_cliente`) REFERENCES `cliente` (`id_cliente`);

--
-- Filtros para la tabla `rutina`
--
ALTER TABLE `rutina`
  ADD CONSTRAINT `rutina_ibfk_2` FOREIGN KEY (`id_aparatos`) REFERENCES `aparato` (`id_aparatos`);

--
-- Filtros para la tabla `rutina_profesor`
--
ALTER TABLE `rutina_profesor`
  ADD CONSTRAINT `rutina_profesor_ibfk_1` FOREIGN KEY (`id_profesor`) REFERENCES `profesor` (`id_profesor`),
  ADD CONSTRAINT `rutina_profesor_ibfk_2` FOREIGN KEY (`id_rutina`) REFERENCES `rutina` (`id_rutina`);

--
-- Filtros para la tabla `sueldo`
--
ALTER TABLE `sueldo`
  ADD CONSTRAINT `sueldo_ibfk_1` FOREIGN KEY (`id_sueldo`) REFERENCES `profesor` (`id_sueldo`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
