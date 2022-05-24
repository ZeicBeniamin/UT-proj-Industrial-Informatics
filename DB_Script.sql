USE [master]
GO

/****** Object:  Database [II_Project]    Script Date: 24.05.2022 22:08:29 ******/
CREATE DATABASE [II_Project]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'II_Project', FILENAME = N'C:\Users\II_Project.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'II_Project_log', FILENAME = N'C:\Users\II_Project_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [II_Project].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [II_Project] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [II_Project] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [II_Project] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [II_Project] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [II_Project] SET ARITHABORT OFF 
GO

ALTER DATABASE [II_Project] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [II_Project] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [II_Project] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [II_Project] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [II_Project] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [II_Project] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [II_Project] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [II_Project] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [II_Project] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [II_Project] SET  DISABLE_BROKER 
GO

ALTER DATABASE [II_Project] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [II_Project] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [II_Project] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [II_Project] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [II_Project] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [II_Project] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [II_Project] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [II_Project] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [II_Project] SET  MULTI_USER 
GO

ALTER DATABASE [II_Project] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [II_Project] SET DB_CHAINING OFF 
GO

ALTER DATABASE [II_Project] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [II_Project] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [II_Project] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [II_Project] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [II_Project] SET QUERY_STORE = OFF
GO

ALTER DATABASE [II_Project] SET  READ_WRITE 
GO

USE [II_Project]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 23.05.2022 21:17:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[id] [int] NOT NULL,
	[name] [varchar](50) NULL,
 CONSTRAINT [PK_Categories_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Chimpanzee_Stats]    Script Date: 23.05.2022 21:17:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chimpanzee_Stats](
	[id] [int] NOT NULL,
	[user_id] [int] NULL,
	[game_time] [float] NULL,
	[avg_memory_time] [float] NULL,
	[avg_solve_time] [float] NULL,
	[date] [varchar](100) NULL,
	[difficulty] [int] NULL,
 CONSTRAINT [PK_Chimpanzee_Stats] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Questions]    Script Date: 23.05.2022 21:17:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Questions](
	[id] [int] NOT NULL,
	[category_id] [int] NULL,
	[question_text] [varchar](500) NULL,
	[question_options] [varchar](1000) NULL,
	[question_answer] [varchar](500) NULL,
	[difficulty] [int] NULL,
 CONSTRAINT [PK_Questions] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Quiz_Stats]    Script Date: 23.05.2022 21:17:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Quiz_Stats](
	[id] [int] NOT NULL,
	[user_id] [int] NULL,
	[corect_answers] [int] NULL,
	[incorect_answers] [int] NULL,
	[time_remaining] [varchar](100) NULL,
	[date] [varchar](100) NULL,
	[difficulty] [int] NULL,
 CONSTRAINT [PK_Quiz_Stats] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stroop_Stats]    Script Date: 23.05.2022 21:17:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stroop_Stats](
	[id] [int] NOT NULL,
	[user_id] [int] NULL,
	[total_time] [float] NULL,
	[clicked_under_bar] [int] NULL,
	[consecutive_strikes] [int] NULL,
	[score] [int] NULL,
	[date] [datetime] NULL,
	[difficulty] [int] NULL,
 CONSTRAINT [PK_Stroop_Stats] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 23.05.2022 21:17:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[user_id] [int] NOT NULL,
	[user_name] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[isAdmin] [int] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [II_Project]
INSERT INTO Questions 
 VALUES 
(1, 0, 'Grand Central Terminal, Park Avenue, New York is the world''s', 'largest railway station;highest railway station;longest railway station;None of the above', 'largest railway station', 2), 
(2, 0, 'Entomology is the science that studies', 'Behavior of human beings;Insects;The origin and history of technical and scientific terms;The formation of rocks', 'Insects', 3), 
(3, 0, 'Eritrea, which became the 182nd member of the UN in 1993, is in the continent of', 'Asia;Africa;Europe;Australia', 'Africa', 1), 
(4, 0, 'Garampani sanctuary is located at', 'Junagarh, Gujarat;Diphu, Assam;Kohima, Nagaland;Gangtok, Sikkim', 'Diphu, Assam', 2), 
(5, 0, 'For which of the following disciplines is Nobel Prize awarded?', 'Physics and Chemistry;Physiology or Medicine;Literature, Peace and Economics;All of the above', 'All of the above', 3), 
(6, 0, 'Hitler party which came into power in 1933 is known as', 'Labour Party;Nazi Party;Ku-Klux-Klan;Democratic Party', 'Nazi Party', 1), 
(7, 0, 'FFC stands for', 'Foreign Finance Corporation;Film Finance Corporation;Federation of Football Council;None of the above', 'Film Finance Corporation', 2), 
(8, 0, 'Fastest shorthand writer was', 'DrG Bist;J.RTata;J.MTagore;Khudada Khan', 'DrG Bist', 3), 
(9, 0, 'Epsom (England) is the place associated with', 'Horse racing;Polo;Shooting;Snooker', 'Horse racing', 1), 
(10, 0, 'First human heart transplant operation conducted by DrChristiaan Barnard on Louis Washkansky, was conducted in', '1967;1968;1958;1922', '1967', 2), 
(11, 0, 'Galileo was an Italian astronomer who', 'developed the telescope;discovered four satellites of Jupiter;discovered that the movement of pendulum produces a regular time measurement;All of the above', 'All of the above', 3), 
(12, 0, 'Habeas Corpus Act 1679', 'states that no one was to be imprisoned without a writ or warrant stating the charge against him;provided facilities to a prisoner to obtain either speedy trial or release in bail;safeguarded the personal liberties of the people against arbitrary imprisonment by the king''s orders;All of the above', 'All of the above', 1), 
(13, 0, 'Exposure to sunlight helps a person improve his health because', 'the infrared light kills bacteria in the body;resistance power increases;the pigment cells in the skin get stimulated and produce a healthy tan;the ultraviolet rays convert skin oil into Vitamin D', 'the ultraviolet rays convert skin oil into Vitamin D', 2), 
(14, 0, 'Golf player Vijay Singh belongs to which country?', 'USA;Fiji;India;UK', 'Fiji', 3), 
(15, 0, 'Guarantee to an exporter that the importer of his goods will pay immediately for the goods ordered by him, is known as', 'Letter of Credit (L/C);laissezfaire;inflation;None of the above', 'Letter of Credit (L/C)', 1), 
(16, 0, 'First Afghan War took place in', '1839;1843;1833;1848', '1839', 2), 
(17, 0, 'Gulf cooperation council was originally formed by', 'Bahrain, Kuwait, Oman, Qatar, Saudi Arabia and United Arab Emirates;Second World Nations;Third World Nations;Fourth World Nations', 'Bahrain, Kuwait, Oman, Qatar, Saudi Arabia and United Arab Emirates', 3), 
(18, 0, 'First China War was fought between', 'China and Britain;China and France;China and Egypt;China and Greek', 'China and Britain', 1), 
(19, 0, 'Dumping is', 'selling of goods abroad at a price well below the production cost at the home market price;the process by which the supply of a manufacture''s product remains low in the domestic market, which batches him better price;prohibited by regulations of GATT;All of the above', 'All of the above', 2), 
(20, 0, 'For the Olympics and World Tournaments, the dimensions of basketball court are', '26 m x 14 m;28 m x 15 m;27 m x 16 m;28 m x 16 m', '28 m x 15 m', 3), 
(21, 0, 'Federation Cup, World Cup, Allywyn International Trophy and Challenge Cup are awarded to winners of', 'Tennis;Volleyball;Basketball;Cricket', 'Volleyball', 1), 
(22, 0, 'Each year World Red Cross and Red Crescent Day is celebrated on', 'May 8;May 18;June 8;June 18', 'May 8', 2), 
(23, 0, 'Famous sculptures depicting art of love built some time in 950 AD - 1050 AD are', 'Khajuraho temples;Jama Masjid;Sun temple;Mahabalipuram temples', 'Khajuraho temples', 3), 
(24, 0, 'Gravity setting chambers are used in industries to remove', 'SOx;NOx;suspended particulate matter;CO', 'suspended particulate matter', 1), 
(25, 0, 'Guwahati High Court is the judicature of', 'Nagaland;Arunachal Pradesh;Assam;All of the above', 'All of the above', 2), 
(26, 0, 'Friction can be reduced by changing from', 'sliding to rolling;rolling to sliding;potential energy to kinetic energy;dynamic to static', 'sliding to rolling', 3), 
(27, 0, 'During eleventh Antarctic Expedition in Nov. 1991/March 1992 ____ was installed.', 'SODAR (SOnic Detection And Ranging);Second Permanent Station ''Maitree'';First permanent station ''Dakshin Gangotri'';None of the above', 'SODAR (SOnic Detection And Ranging)', 1), 
(28, 0, 'From the following, choose the set in which names of Secretary-Generals of the UNO are arranged in correct chronological order?', 'U Thant, Kurt Waldheim, Dag Hammarskjoeld, Trygve Lie.;Trygve Lie, Dag Hammarskjoeld, U Thant, Kurt Waldheim.;Trygve Lie, U Thant , Dag Hammarskjoeld, Kurt Waldheim.;U Thant, Dag Hammarskjoeld, Trygve Lie, Kurt Waldheim.', 'Trygve Lie, Dag Hammarskjoeld, U Thant, Kurt Waldheim.', 2), 
(29, 0, 'Fire temple is the place of worship of which of the following religion?', 'Taoism;Judaism;Zoroastrianism (Parsi Religion);Shintoism', 'Zoroastrianism (Parsi Religion)', 3), 
(30, 0, 'Film and TV institute of India is located at', 'Pune (Maharashtra);Rajkot (Gujarat);Pimpri (Maharashtra);Perambur (Tamilnadu)', 'Pune (Maharashtra)', 1), 
(31, 1, 'Radiocarbon is produced in the atmosphere as a result of', 'collision between fast neutrons and nitrogen nuclei present in the atmosphere;action of ultraviolet light from the sun on atmospheric oxygen;action of solar radiations particularly cosmic rays on carbon dioxide present in the atmosphere;lightning discharge in atmosphere', 'collision between fast neutrons and nitrogen nuclei present in the atmosphere', 2), 
(32, 1, 'It is easier to roll a stone up a sloping road than to lift it vertical upwards because', 'work done in rolling is more than in lifting;work done in lifting the stone is equal to rolling it;work done in both is same but the rate of doing work is less in rolling;work done in rolling a stone is less than in lifting it', 'work done in rolling a stone is less than in lifting it', 3), 
(33, 1, 'The absorption of ink by blotting paper involves', 'viscosity of ink;capillary action phenomenon;diffusion of ink through the blotting;siphon action', 'capillary action phenomenon', 1), 
(34, 1, 'Siphon will fail to work if', 'the densities of the liquid in the two vessels are equal;the level of the liquid in the two vessels are at the same height;both its limbs are of unequal length;the temperature of the liquids in the two vessels are the same', 'the level of the liquid in the two vessels are at the same height', 2), 
(35, 1, 'Large transformers, when used for some time, become very hot and are cooled by circulating oil. The heating of the transformer is due to', 'the heating effect of current alone;hysteresis loss alone;both the heating effect of current and hysteresis loss;intense sunlight at noon', 'both the heating effect of current and hysteresis loss', 3), 
(36, 1, 'Nuclear sizes are expressed in a unit named', 'Fermi;angstrom;newton;tesla', 'angstrom', 1), 
(37, 1, 'Light year is a unit of', 'time;distance;light;intensity of light', 'distance', 2), 
(38, 1, 'Mirage is due to', 'unequal heating of different parts of the atmosphere;magnetic disturbances in the atmosphere;depletion of ozone layer in the atmosphere;equal heating of different parts of the atmosphere', 'unequal heating of different parts of the atmosphere', 3), 
(39, 1, 'Light from the Sun reaches us in nearly', '2 minutes;4 minutes;8 minutes;16 minutes', '8 minutes', 1), 
(40, 1, 'Stars appears to move from east to west because', 'all stars move from east to west;the earth rotates from west to east;the earth rotates from east to west;the background of the stars moves from west to east', 'the earth rotates from west to east', 2), 
(41, 1, 'Pa(Pascal) is the unit for', 'thrust;pressure;frequency;conductivity', 'pressure', 3), 
(42, 1, 'Planets do not twinkle because', 'they emit light of a constant intensity;their distance from the earth does not change with time;they are very far away from the earth resulting in decrease in intensity of light;they are nearer to earth and hence we receive a greater amount of light and, therefore minor variations in the intensity are not noticeable', 'they are nearer to earth and hence we receive a greater amount of light and, therefore minor variations in the intensity are not noticeable', 1), 
(43, 1, 'Metals are good conductors of electricity because', 'they contain free electrons;the atoms are lightly packed;they have high melting point;All of the above', 'they contain free electrons', 2), 
(44, 1, 'Let a thin capillary tube be replaced with another tube of insufficient length then, we find water', 'will overflow;will not rise;depressed;change its meniscus', 'will not rise', 3), 
(45, 1, 'Out of the following pairs, choose the pair in which the physical quantities do not have identical dimension?', 'Pressure and Young''s modules;Planck''s constant and Angular momentum;Impulse and moment of force;Force and rate of change of linear momentum', 'Impulse and moment of force', 1), 
(46, 1, 'If two bodies of different masses, initially at rest, are acted upon by the same force for the same time, then the both bodies acquire the same', 'velocity;momentum;acceleration;kinetic energy', 'momentum', 2), 
(47, 1, 'Pick out the scalar quantity', 'force;pressure;velocity;acceleration', 'pressure', 3), 
(48, 1, 'Rectifiers are used to convert', 'Direct current to Alternating current;Alternating current to Direct current;high voltage to low voltage;low voltage to high voltage', 'Alternating current to Direct current', 1), 
(49, 1, 'out of the following, which is not emitted by radioactive substance?', 'Electrons;Electromagnetic radiations;Alpha particles;Neutrons', 'Neutrons', 2), 
(50, 1, 'Sound waves in air are', 'transverse;longitudinal;electromagnetic;polarised', 'longitudinal', 3), 
(51, 1, 'Magnetism at the centre of a bar magnet is', 'minimum;maximum;zero;minimum or maximum', 'zero', 1), 
(52, 1, 'It is more difficult to walk on a sandy road than on a concrete road because', 'sand is soft and concreter is hard;the friction between sand and feet is less than that between concrete and feet;the friction between sand and feet is more than that between concrete and feet;the sand is grainy but concrete is smooth', 'the friction between sand and feet is less than that between concrete and feet', 2), 
(53, 1, 'Find the maximum velocity for the overturn of a car moving on a circular track of radius 100 m. The co-efficient of friction between the road and tyre is 0.2', '0.14 m/s;140 m/s;1.4 km/s;14 m/s', '14 m/s', 3), 
(54, 1, 'Of the following properties of a wave, the one that is independent of the other is its', 'amplitude;velocity;wavelength;frequency', 'amplitude', 1), 
(55, 1, 'Lux is the SI unit of', 'intensity of illumination;luminous efficiency;luminous flux;luminous intensity', 'intensity of illumination', 2), 
(56, 1, 'On a rainy day, small oil films on water show brilliant colours. This is due to', 'dispersion;interference;diffraction;polarization', 'interference', 3), 
(57, 1, 'Point A is at a lower electrical potential than point B. An electron between them on the line joining them will', 'move towards A;move towards B;move at right angles to the line joining A and B;remain at rest', 'move towards B', 1), 
(58, 1, 'Materials for rain-proof coats and tents owe their water-proof properties to', 'surface tension;viscosity;specific gravity;elasticity', 'surface tension', 2), 
(59, 1, 'RADAR is used for', 'locating submerged submarines;receiving a signals in a radio receiver;locating geostationary satellites;detecting and locating the position of objects such as aeroplanes', 'detecting and locating the position of objects such as aeroplanes', 3), 
(60, 1, 'Sound of frequency below 20 Hz is called', 'audio sounds;infrasonic;ultrasonic;supersonics', 'infrasonic', 1), 
(61, 2, 'The nucleus of an atom consists of', 'electrons and neutrons;electrons and protons;protons and neutrons;All of the above', 'protons and neutrons', 2), 
(62, 2, 'The number of moles of solute present in 1 kg of a solvent is called its', 'molality;molarity;normality;formality', 'molality', 3), 
(63, 2, 'The most electronegative element among the following is', 'sodium;bromine;fluorine;oxygen', 'fluorine', 1), 
(64, 2, 'The metal used to recover copper from a solution of copper sulphate is', 'Na;Ag;Hg;Fe', 'Fe', 2), 
(65, 2, 'The number of d-electrons in Fe2+ (Z = 26) is not equal to that of', 'p-electrons in Ne(Z = 10);s-electrons in Mg(Z = 12);d-electrons in Fe(Z = 26);p-electrons in CI(Z = 17)', 'p-electrons in CI(Z = 17)', 3), 
(66, 2, 'The metallurgical process in which a metal is obtained in a fused state is called', 'smelting;roasting;calcinations;froth floatation', 'smelting', 1), 
(67, 2, 'The molecules of which gas have highest speed?', 'H2 at -73oC;CH4 at 300 K;N2 at 1,027oC;O2 at 0oC', 'H2 at -73oC', 2), 
(68, 2, 'The oldest rocks in the earth''s crust were once molten, and came from deep inside the earth. The molten rock, called magma, spewed out in volcanic eruptions during the earth;s early life and solidified into hard rock''s called', 'granite;basalt;igneous rocks;sedimentary rocks', 'igneous rocks', 3), 
(69, 2, 'The law which states that the amount of gas dissolved in a liquid is proportional to its partial pressure is', 'Dalton''s law;Gay Lussac''s law;Henry''s law;Raoult''s law', 'Henry''s law', 1), 
(70, 2, 'The main buffer system of the human blood is', 'H2CO3 - HCO3;H2CO3 - CO32-;CH3COOH - CH3COO-;NH2CONH2 - NH2CONH+', 'H2CO3 - HCO3', 2), 
(71, 2, 'The gas present in the stratosphere which filters out some of the sun''s ultraviolet light and provides an effective shield against radiation damage to living things is', 'helium;ozone;oxygen;methane', 'ozone', 3), 
(72, 2, 'The most commonly used bleaching agent is', 'alcohol;carbon dioxide;chlorine;sodium chlorine', 'chlorine', 1), 
(73, 2, 'The nucleus of a hydrogen atom consists of', '1 proton only;1 proton + 2 neutron;1 neutron only;1 electron only', '1 proton only', 2), 
(74, 2, 'The heat required to raise the temperature of body by 1 K is called', 'specific heat;thermal capacity;water equivalent;None of the above', 'thermal capacity', 3), 
(75, 2, 'The nuclear particles which are assumed to hold the nucleons together are', 'electrons;positrons;neutrons;mesons', 'mesons', 1), 
(76, 2, 'The mass of P4O10 that will be obtained from the reaction of 1.33 gram of P4 and 5.07 of oxygen is', '2.05 gram;3.05 gram;4.05 gram;5.05 gram', '3.05 gram', 2), 
(77, 2, 'The octane number of zero is assigned to', '2-methyl octane;n-heptane;iso-octane;3-methyl octane', 'n-heptane', 3), 
(78, 2, 'The metal that is used as a catalyst in the hydrogenation of oils is', 'Ni;Pb;Cu;Pt', 'Ni', 1), 
(79, 2, 'The most abundant rare gas in the atmosphere is', 'He;Ne;Ar;Xe', 'Ar', 2), 
(80, 2, 'The Latin word formica means ant. The name formic acid is derived from this Latin word because', 'this acid, in ancient times, was used to eliminate ant-hills;this corrosive acid is secreted by ants to drive away their enemies;this acid was first obtained by the distillation of ants;ants are attracted by the odour of this acid', 'this acid was first obtained by the distillation of ants', 3), 
(81, 2, 'The ore which is found in abundance in India is', 'monazite;fluorspar;bauxite;magnetite', 'monazite', 1), 
(82, 2, 'The inherited traits of an organism are controlled by', 'RNA molecules;nucleotides;DNA molecules;enzymes', 'DNA molecules', 2), 
(83, 2, 'The heat energy produced when the human body metabolises 1 gram of fat is', '30 KJ;1 KJ;39 KJ;29 KJ', '39 KJ', 3), 
(84, 2, 'What are the number of moles of CO2 which contains 16 g of oxygen?', '0.5 mole;0.2 mole;0.4 mole;0.25 mole', '0.5 mole', 1), 
(85, 2, 'The main use of salt in the diet is to', 'make the taste of food better;produce in small amounts the hydrochloric acid required for the digestion of food;ease the process of cooking;increase the solubility of food particles in water', 'produce in small amounts the hydrochloric acid required for the digestion of food', 2), 
(86, 2, 'The monomer of polythene is', 'vinyl chloride;ethylene;ethyl alcohol;None of the above', 'ethylene', 3), 
(87, 2, 'The luster of a metal is due to', 'its high density;its high polishing;its chemical inertness;presence of free electrons', 'presence of free electrons', 1), 
(88, 2, 'The number of water molecules present in a drop of water (volume 0.0018 ml) at room temperature is', '1.568 x 103;6.023 x 1019;4.84 x 1017;6.023 x 1023', '6.023 x 1019', 2), 
(89, 2, 'The most malleable metal is', 'platinum;silver;iron;gold', 'gold', 3), 
(90, 2, 'The oil used in the froth floatation process is', 'coconut oil;olive oil;kerosene oil;pine oil', 'pine oil', 1), 
(91, 3, 'Ordinary table salt is sodium chloride. What is baking soda?', 'Potassium chloride;Potassium carbonate;Potassium hydroxide;Sodium bicarbonate', 'Sodium bicarbonate', 2), 
(92, 3, 'Ozone hole refers to', 'hole in ozone layer;decrease in the ozone layer in troposphere;decrease in thickness of ozone layer in stratosphere;increase in the thickness of ozone layer in troposphere', 'decrease in thickness of ozone layer in stratosphere', 3), 
(93, 3, 'Pine, fir, spruce, cedar, larch and cypress are the famous timber-yielding plants of which several also occur widely in the hilly regions of India. All these belong to', 'angiosperms;gymnosperms;monocotyledons;dicotyledons', 'gymnosperms', 1), 
(94, 3, 'Pollination is best defined as', 'transfer of pollen from anther to stigma;germination of pollen grains;growth of pollen tube in ovule;visiting flowers by insects', 'transfer of pollen from anther to stigma', 2), 
(95, 3, 'Plants receive their nutrients mainly from', 'chlorophyll;atmosphere;light;soil', 'soil', 3), 
(96, 3, 'Movement of cell against concentration gradient is called', 'osmosis;active transport;diffusion;passive transport', 'active transport', 1), 
(97, 3, 'Photosynthesis generally takes place in which parts of the plant?', 'Leaf and other chloroplast bearing parts;stem and leaf;Roots and chloroplast bearing parts;Bark and leaf', 'Leaf and other chloroplast bearing parts', 2), 
(98, 3, 'Most fish do not sink in water because of the presence of: I - swim bladder, II - air bladder, III - air sacs IV -air in spongy bones:', 'I and II are correct;II and III are correct;III and IV are correct;I, II, III and IV are correct', 'I and II are correct', 3), 
(99, 3, 'Plants synthesis protein from', 'starch;sugar;amino acids;fatty acids', 'amino acids', 1), 
(100, 3, 'Plants absorb dissolved nitrates from soil and convert them into', 'free nitrogen;urea;ammonia;proteins', 'free nitrogen', 2), 
(101, 3, 'Out of 900 reported species of living gymnosperms, conifers are represented by about 500 species, About 2,50,000 species of angiosperms (flowering plants) have also been reported in the world. The vast and dominant woodlands in Europe, Asia, North America and mountains such as Himalayas are wooded with', 'all gymnosperms, except conifers;only angiosperms;only conifers;angiosperms and all gymnosperms except conifers', 'only conifers', 3), 
(102, 3, 'One of the following is not a function of bones.', 'Place for muscle attachment;Protection of vital organs;Secretion of hormones for calcium regulation in blood and bones;Production of blood corpuscles', 'Secretion of hormones for calcium regulation in blood and bones', 1), 
(103, 3, 'Plants absorb most part of water needed by them through their', 'embryonic zone;growing point;root hairs;zone of elongation', 'root hairs', 2), 
(104, 3, 'Photo-oxidation is', 'photorespiration;photolysis;light and oxygen induced breakdown;All of the above', 'All of the above', 3), 
(105, 3, 'Process of cell division can take place by', 'heterosis;fusion;mitosis;None of these', 'mitosis', 1), 
(106, 3, 'Most highly intelligent mammals are', 'whales;dolphins;elephants;kangaroos', 'dolphins', 2), 
(107, 3, 'Plant development is influenced by', 'quality of light only;quality and quantity of light;quality and duration of light;quality, quantity and duration of light', 'quality, quantity and duration of light', 3), 
(108, 3, 'Prokaryotic cells lack', 'nucleolus;nuclear membrane;membrane bound by organelles;All of these', 'All of these', 1), 
(109, 3, 'Photosynthesis takes place faster in', 'yellow light;white light;red light;darkness', 'white light', 2), 
(110, 3, 'Nucleus, the genetic material containing rounded body in each cell, was first discovered in 1831 by', 'Robert Hooke;Robert Brown;Rudolf Virchow;Theodore Schwann', 'Robert Brown', 3), 
(111, 3, 'Primary phloem develops from', 'lateral meristem;protoderm;extrastelar cambium;provascular tissue', 'provascular tissue', 1), 
(112, 3, 'Other than spreading malaria, anopheles mosquitoes are also vectors of', 'dengue fever;filariasis;encephalitis;yellow fever', 'filariasis', 2), 
(113, 3, 'Plants that grow in saline water are called', 'halophytes;hydrophytes;mesophytes;thallophytes', 'halophytes', 3), 
(114, 3, 'Pyorrhoea is a disease of the', 'nose;gums;heart;lungs', 'gums', 1), 
(115, 3, 'O2 released in the process of photosynthesis comes from', 'CO2;water;sugar;pyruvic acid', 'water', 2), 
(116, 3, 'Placenta is the structure formed', 'by the union of foetal and uterine tissue;by foetus only;by fusion of germ layers;None of these', 'by the union of foetal and uterine tissue', 3), 
(117, 3, 'Plants hormone that induces cell division is', 'auxins;gibberellins;kinins;domins', 'kinins', 1), 
(118, 3, 'Neurospora is used as genetic material because', 'it has short life cycle of 10 days;the product of single meiosis can be easily analysed;meiotic products are linearly arranged in the form of ordered tetrads;is a diploid fungus', 'it has short life cycle of 10 days', 2), 
(119, 3, 'Phloem is a tissue found in', 'reproductive organs of animals;plants;insects;mammals', 'plants', 3), 
(120, 3, 'N2 content is kept constant in the biosphere due to', 'N2 fixation;industrial pollution;nitrogen cycle;absorption of N2', 'nitrogen cycle', 1), 
(121, 4, 'In which decade was the American Institute of Electrical Engineers (AIEE) founded?', '1850s;1880s;1930s;1950s', '1880s', 2), 
(122, 4, 'What is part of a database that holds only one type of information?', 'Report;Field;Record;File', 'Field', 3), 
(123, 4, '''OS'' computer abbreviation usually means ?', 'Order of Significance;Open Software;Operating System;Optical Sensor', 'Operating System', 1), 
(124, 4, 'In which decade with the first transatlantic radio broadcast occur?', '1850s;1860s;1870s;1900s', '1900s', 2), 
(125, 4, '''.MOV'' extension refers usually to what kind of file?', 'Image file;Animation/movie file;Audio file;MS Office document', 'Animation/movie file', 3), 
(126, 4, 'In which decade was the SPICE simulator introduced?', '1950s;1960s;1970s;1980s', '1970s', 1), 
(127, 4, 'Most modern TV''s draw power even if turned off. The circuit the power is used in does what function?', 'Sound;Remote control;Color balance;High voltage', 'Remote control', 2), 
(128, 4, 'Which is a type of Electrically-Erasable Programmable Read-Only Memory?', 'Flash;Flange;Fury;FRAM', 'Flash', 3), 
(129, 4, 'The purpose of choke in tube light is ?', 'To decrease the current;To increase the current;To decrease the voltage momentarily;To increase the voltage momentarily', 'To increase the voltage momentarily', 1), 
(130, 4, '''.MPG'' extension refers usually to what kind of file?', 'WordPerfect Document file;MS Office document;Animation/movie file;Image file', 'Animation/movie file', 2), 
(131, 4, 'Who is largely responsible for breaking the German Enigma codes, created a test that provided a foundation for artificial intelligence?', 'Alan Turing;Jeff Bezos;George Boole;Charles Babbage', 'Alan Turing', 3), 
(132, 4, 'Who developed Yahoo?', 'Dennis Ritchie & Ken Thompson;David Filo & Jerry Yang;Vint Cerf & Robert Kahn;Steve Case & Jeff Bezos', 'David Filo & Jerry Yang', 1), 
(133, 4, 'Made from a variety of materials, such as carbon, which inhibits the flow of current...?', 'Choke;Inductor;Resistor;Capacitor', 'Resistor', 2), 
(134, 4, 'The most common format for a home video recorder is VHS. VHS stands for...?', 'Video Home System;Very high speed;Video horizontal standard;Voltage house standard', 'Video Home System', 3), 
(135, 4, 'What does VVVF stand for?', 'Variant Voltage Vile Frequency;Variable Velocity Variable Fun;Very Very Vicious Frequency;Variable Voltage Variable Frequency', 'Variable Voltage Variable Frequency', 1), 
(136, 4, 'What frequency range is the High Frequency band?', '100 kHz;1 GHz;30 to 300 MHz;3 to 30 MHz', '3 to 30 MHz', 2), 
(137, 4, 'The first step to getting output from a laser is to excite an active medium. What is this process called?', 'Pumping;Exciting;Priming;Raising', 'Pumping', 3), 
(138, 4, 'What is the relationship between resistivity r and conductivity s?', 'R = s2;R = s;R > s;R = 1/s', 'R = 1/s', 1), 
(139, 4, 'Which motor is NOT suitable for use as a DC machine?', 'Permanent magnet motor;Series motor;Squirrel cage motor;Synchronous motor', 'Squirrel cage motor', 2), 
(140, 4, 'A given signal''s second harmonic is twice the given signal''s __________ frequency...?', 'Fourier;Foundation;Fundamental;Field', 'Fundamental', 3), 
(141, 4, 'In which year was MIDI(Musical Instrument Digital Interface) introduced?', '1987;1983;1973;1977', '1983', 1), 
(142, 4, 'What does the term PLC stand for?', 'Programmable Lift Computer;Program List Control;Programmable Logic Controller;Piezo Lamp Connector', 'Programmable Logic Controller', 2), 
(143, 4, 'When measuring the characteristics of a small-signal amplifier, say for a radio receiver, one might be concerned with its "Noise..."?', 'Fundamental;Fall;Force;Figure', 'Figure', 3), 
(144, 4, '''DB'' computer abbreviation usually means ?', 'Database;Double Byte;Data Block;Driver Boot', 'Database', 1), 
(145, 4, '''.INI'' extension refers usually to what kind of file?', 'Image file;System file;Hypertext related file;Image Color Matching Profile file', 'System file', 2), 
(146, 4, 'The sampling rate, (how many samples per second are stored) for a CD is...?', '48.4 kHz;22,050 Hz;44.1 kHz;48 kHz', '44.1 kHz', 3), 
(147, 4, 'Who created Pretty Good Privacy (PGP)?', 'Phil Zimmermann;Tim Berners-Lee;Marc Andreessen;Ken Thompson', 'Phil Zimmermann', 1), 
(148, 4, 'What do we call a network whose elements may be separated by some distance? It usually involves two or more small networks and dedicated high-speed telephone lines.', 'URL (Universal Resource Locator);LAN (Local Area Network);WAN (Wide Area Network);World Wide Web', 'WAN (Wide Area Network)', 2), 
(149, 4, 'After the first photons of light are produced, which process is responsible for amplification of the light?', 'Blackbody radiation;Stimulated emission;Planck''s radiation;Einstein oscillation', 'Stimulated emission', 3), 
(150, 4, 'Which is NOT an acceptable method of distributing small power outlets throughout an open plan office area?', 'Power Poles;Power Skirting;Flush Floor Ducting;Extension Cords', 'Extension Cords', 1), 
(151, 5, 'The Homolographic projection has the correct representation of', 'shape;area;baring;distance', 'area', 2), 
(152, 5, 'The latitudinal differences in pressure delineate a number of major pressure zones, which correspond with', 'zones of climate;zones of oceans;zones of land;zones of cyclonic depressions', 'zones of climate', 3), 
(153, 5, 'The higher the wind speed and the longer the fetch or distance of open water across which the wind blows and waves travel, the ____ waves and the ____ energy they process.', 'larger, more;larger, less;smaller, more;smaller, less', 'larger, more', 1), 
(154, 5, 'The hazards of radiation belts include', 'deterioration of electronic circuits;damage of solar cells of spacecraft;adverse effect on living organisms;All of the above', 'All of the above', 2), 
(155, 5, 'The great Victoria Desert is located in', 'Canada;West Africa;Australia;North America', 'Australia', 3), 
(156, 5, 'The intersecting lines drawn on maps and globes are', 'latitudes;longitudes;geographic grids;None of the above', 'geographic grids', 1), 
(157, 5, 'The light of distant stars is affected by', 'a. the earth''s atmosphere;b. interstellar dust;c. both a and b;d. None of the above', 'c. both a and b', 2), 
(158, 5, 'The landmass of which of the following continents is the least?', 'Africa;Asia;Australia;Europe', 'Australia', 3), 
(159, 5, 'Without ____ the equator would be much hotter than it is while the poles would be much cooler.', 'latitudinal redistribution of heat;cycle of air circulation;global wind pattern;All are similar terms', 'All are similar terms', 1), 
(160, 5, 'The habitats valuable for commercially harvested species are called', 'coral reefs;sea grass bed;hot spots;None of the above', 'sea grass bed', 2), 
(161, 5, 'Which of the following is tropical grassland?', 'Taiga;Savannah;Pampas;Prairies', 'Savannah', 3), 
(162, 5, 'With the disintegration of USSR in end 1991, comprised of ____ Union Republics.', '15;10;5;25', '15', 1), 
(163, 5, 'The iron and steel industries of which of the following countries are almost fully dependent on imported raw materials?', 'Britain;Japan;Poland;Germany', 'Japan', 2), 
(164, 5, 'The temperature increases rapidly after', 'ionosphere;exosphere;stratosphere;troposphere', 'ionosphere', 3), 
(165, 5, 'The humidity of the air depends upon', 'temperature;location;weather;All of the above', 'All of the above', 1), 
(166, 5, 'The groundwater can become confined between two impermeable layers. This type of enclosed water is called', 'artesian;artesian well;unconfined groundwater;confined groundwater', 'artesian', 2), 
(167, 5, 'The largest glaciers are', 'mountain glaciers;alpine glaciers;continental glaciers;piedmont glaciers', 'continental glaciers', 3), 
(168, 5, 'The ionosphere includes', 'mesosphere;thermosphere;thermosphere and exosphere;thermosphere, exosphere and mesosphere', 'thermosphere and exosphere', 1), 
(169, 5, 'The highest degree of concentration of mineral deposits are found in', 'northeastern zone;northwestern zone;southern zone;All of the above', 'northeastern zone', 2), 
(170, 5, 'The group of minerals chemically containing hydrocarbons is', 'silicate group;organic group;oxide group;hydride group', 'organic group', 3), 
(171, 5, 'The iron ore mined at Bailadila is mostly', 'haematite;siderite;limonite;magnetic', 'haematite', 1), 
(172, 5, 'The leading state in producing paper is', 'Bihar;West Bengal;Kerala;Orissa', 'West Bengal', 2), 
(173, 5, 'The largest dune files are found in', 'Middle East;North Africa;both (a) and (b);None of the above', 'both (a) and (b)', 3), 
(174, 5, 'The Harmattan is', 'cool, extremely dry wind that forms over the Sahara and blows westward or south-westward to the African coast;wind that blows during the dry season from December to February;tertiary wind that carry great quantities of fine dust from the Sahara;All of the above', 'All of the above', 1), 
(175, 5, 'The largest gold producing country in the world(in 2006) is', 'China;Canada;South Africa;USA', 'South Africa', 2), 
(176, 5, 'The hydrological cycle is a conceptual model that describes', 'the storage of water between biosphere, hydrosphere, atmosphere and lithosphere;the movement of water between biosphere, atmosphere, lithosphere and hydrosphere;both (a) and (b);None of the above', 'both (a) and (b)', 3), 
(177, 5, 'The least explosive type of volcano is called', 'Basalt plateau;Cinder cone;Shield volcanoes;Composite volcanoes', 'Basalt plateau', 1), 
(178, 5, 'The largest fish exporting region in the world is', 'the north-east atlantic region;the north-east pacific region;the north-west pacific region;the south-east asian region', 'the north-east atlantic region', 2), 
(179, 5, 'The largest country of the world by geographical area is', 'Russia;Vatican City;Australia;USA', 'Russia', 3), 
(180, 5, 'The hot and cold deserts together occupy nearly ____ land area of the world.', '1/2;1/4th;1/3rd;3/4th', '1/3rd', 1);

INSERT INTO Chimpanzee_Stats 
VALUES 
(0, 0, '01.10', '00.35', '00.35', '18.04.2022', 2),
(1, 0, '00.29', '00.14', '00.15', '19.04.2022', 0),
(2, 0, '00.43', '00.20', '00.23', '20.04.2022', 1),
(3, 0, '00.23', '00.13', '00.10', '21.04.2022', 0),
(4, 0, '01.06', '00.35', '00.31', '21.04.2022', 2),
(5, 0, '00.19', '00.08', '00.11', '21.04.2022', 0),
(6, 0, '00.24', '00.09', '00.15', '21.04.2022', 0),
(7, 0, '00.28', '00.13', '00.15', '22.04.2022', 0),
(8, 0, '00.20', '00.06', '00.14', '22.04.2022', 0),
(9, 0, '00.41', '00.21', '00.20', '23.04.2022', 1),
(10, 0, '00.19', '00.05', '00.14', '24.04.2022', 0),
(11, 0, '01.10', '00.34', '00.36', '24.04.2022', 2),
(12, 0, '00.23', '00.06', '00.17', '24.04.2022', 0),
(13, 0, '00.27', '00.11', '00.16', '25.04.2022', 0),
(14, 0, '00.28', '00.14', '00.14', '25.04.2022', 0),
(15, 0, '00.19', '00.07', '00.12', '26.04.2022', 0),
(16, 0, '01.04', '00.33', '00.31', '26.04.2022', 2),
(17, 0, '00.21', '00.08', '00.13', '27.04.2022', 0),
(18, 0, '00.51', '00.25', '00.26', '29.04.2022', 1),
(19, 0, '00.18', '00.05', '00.13', '29.04.2022', 0),
(20, 0, '01.07', '00.33', '00.34', '29.04.2022', 2),
(21, 0, '00.42', '00.17', '00.25', '30.04.2022', 1),
(22, 0, '00.22', '00.07', '00.15', '01.05.2022', 0),
(23, 0, '00.44', '00.19', '00.25', '02.05.2022', 1),
(24, 0, '00.45', '00.18', '00.27', '03.05.2022', 1),
(25, 0, '00.52', '00.25', '00.27', '04.05.2022', 1),
(26, 0, '00.16', '00.05', '00.11', '04.05.2022', 0),
(27, 0, '00.36', '00.16', '00.20', '05.05.2022', 1),
(28, 0, '00.23', '00.12', '00.11', '06.05.2022', 0),
(29, 0, '00.42', '00.22', '00.20', '07.05.2022', 1),
(30, 0, '00.37', '00.16', '00.21', '07.05.2022', 1),
(31, 0, '00.46', '00.21', '00.25', '07.05.2022', 1),
(32, 0, '00.44', '00.18', '00.26', '08.05.2022', 1),
(33, 0, '01.07', '00.32', '00.35', '09.05.2022', 2),
(34, 0, '00.24', '00.13', '00.11', '12.05.2022', 0),
(35, 0, '00.41', '00.19', '00.22', '12.05.2022', 1),
(36, 0, '00.18', '00.07', '00.11', '12.05.2022', 0),
(37, 0, '00.35', '00.15', '00.20', '12.05.2022', 1),
(38, 0, '00.19', '00.05', '00.14', '13.05.2022', 0),
(39, 0, '00.40', '00.15', '00.25', '13.05.2022', 1),
(40, 0, '01.04', '00.34', '00.30', '13.05.2022', 2),
(41, 0, '00.24', '00.07', '00.17', '13.05.2022', 0),
(42, 0, '00.28', '00.13', '00.15', '15.05.2022', 0),
(43, 0, '01.07', '00.35', '00.32', '15.05.2022', 2),
(44, 0, '01.01', '00.30', '00.31', '15.05.2022', 2),
(45, 0, '00.48', '00.21', '00.27', '17.05.2022', 1),
(46, 0, '00.45', '00.23', '00.22', '19.05.2022', 1),
(47, 0, '01.06', '00.34', '00.32', '20.05.2022', 2),
(48, 0, '00.59', '00.27', '00.32', '21.05.2022', 2),
(49, 0, '00.42', '00.19', '00.23', '22.05.2022', 1),
(50, 1, '00.20', '00.08', '00.12', '22.04.2022', 0),
(51, 1, '00.20', '00.09', '00.11', '23.04.2022', 0),
(52, 1, '00.44', '00.21', '00.23', '23.04.2022', 1),
(53, 1, '00.17', '00.06', '00.11', '24.04.2022', 0),
(54, 1, '00.27', '00.12', '00.15', '26.04.2022', 0),
(55, 1, '01.04', '00.27', '00.37', '26.04.2022', 2),
(56, 1, '01.12', '00.35', '00.37', '28.04.2022', 2),
(57, 1, '00.28', '00.14', '00.14', '29.04.2022', 0),
(58, 1, '01.01', '00.28', '00.33', '29.04.2022', 2),
(59, 1, '01.08', '00.33', '00.35', '29.04.2022', 2),
(60, 1, '01.03', '00.26', '00.37', '01.05.2022', 2),
(61, 1, '01.02', '00.27', '00.35', '03.05.2022', 2),
(62, 1, '00.44', '00.17', '00.27', '05.05.2022', 1),
(63, 1, '00.55', '00.25', '00.30', '05.05.2022', 2),
(64, 1, '01.02', '00.26', '00.36', '06.05.2022', 2),
(65, 1, '01.00', '00.25', '00.35', '07.05.2022', 2),
(66, 1, '01.06', '00.34', '00.32', '08.05.2022', 2),
(67, 1, '00.40', '00.18', '00.22', '08.05.2022', 1),
(68, 1, '00.41', '00.18', '00.23', '08.05.2022', 1),
(69, 1, '00.29', '00.14', '00.15', '08.05.2022', 0),
(70, 1, '00.48', '00.23', '00.25', '09.05.2022', 1),
(71, 1, '01.06', '00.30', '00.36', '10.05.2022', 2),
(72, 1, '00.40', '00.16', '00.24', '10.05.2022', 1),
(73, 1, '00.37', '00.15', '00.22', '10.05.2022', 1),
(74, 1, '00.29', '00.13', '00.16', '10.05.2022', 0),
(75, 1, '01.03', '00.28', '00.35', '11.05.2022', 2),
(76, 1, '01.09', '00.33', '00.36', '11.05.2022', 2),
(77, 1, '00.58', '00.28', '00.30', '11.05.2022', 2),
(78, 1, '00.26', '00.15', '00.11', '11.05.2022', 0),
(79, 1, '00.38', '00.15', '00.23', '13.05.2022', 1),
(80, 1, '01.06', '00.34', '00.32', '15.05.2022', 2),
(81, 1, '01.10', '00.34', '00.36', '15.05.2022', 2),
(82, 1, '00.40', '00.19', '00.21', '15.05.2022', 1),
(83, 1, '01.02', '00.28', '00.34', '15.05.2022', 2),
(84, 1, '00.28', '00.11', '00.17', '16.05.2022', 0),
(85, 1, '00.20', '00.06', '00.14', '17.05.2022', 0),
(86, 1, '00.41', '00.17', '00.24', '17.05.2022', 1),
(87, 1, '01.04', '00.31', '00.33', '18.05.2022', 2),
(88, 1, '00.46', '00.21', '00.25', '19.05.2022', 1),
(89, 1, '00.41', '00.20', '00.21', '19.05.2022', 1),
(90, 1, '00.17', '00.06', '00.11', '19.05.2022', 0),
(91, 1, '00.25', '00.08', '00.17', '19.05.2022', 0),
(92, 1, '00.26', '00.15', '00.11', '20.05.2022', 0),
(93, 1, '00.24', '00.08', '00.16', '20.05.2022', 0),
(94, 1, '00.48', '00.21', '00.27', '20.05.2022', 1),
(95, 1, '00.29', '00.12', '00.17', '20.05.2022', 0),
(96, 1, '00.58', '00.26', '00.32', '21.05.2022', 2),
(97, 1, '00.37', '00.15', '00.22', '21.05.2022', 1),
(98, 1, '00.58', '00.28', '00.30', '23.05.2022', 2),
(99, 1, '01.05', '00.30', '00.35', '23.05.2022', 2),
(100, 2, '00.24', '00.07', '00.17', '18.04.2022', 0),
(101, 2, '00.30', '00.15', '00.15', '19.04.2022', 0),
(102, 2, '01.06', '00.35', '00.31', '20.04.2022', 2),
(103, 2, '01.03', '00.26', '00.37', '20.04.2022', 2),
(104, 2, '00.26', '00.14', '00.12', '21.04.2022', 0),
(105, 2, '00.41', '00.18', '00.23', '21.04.2022', 1),
(106, 2, '00.57', '00.27', '00.30', '22.04.2022', 2),
(107, 2, '00.41', '00.17', '00.24', '22.04.2022', 1),
(108, 2, '01.08', '00.33', '00.35', '22.04.2022', 2),
(109, 2, '01.07', '00.33', '00.34', '23.04.2022', 2),
(110, 2, '00.58', '00.26', '00.32', '24.04.2022', 2),
(111, 2, '00.39', '00.15', '00.24', '28.04.2022', 1),
(112, 2, '00.40', '00.15', '00.25', '28.04.2022', 1),
(113, 2, '00.17', '00.06', '00.11', '30.04.2022', 0),
(114, 2, '00.30', '00.13', '00.17', '01.05.2022', 0),
(115, 2, '00.22', '00.08', '00.14', '01.05.2022', 0),
(116, 2, '00.40', '00.18', '00.22', '01.05.2022', 1),
(117, 2, '01.08', '00.31', '00.37', '02.05.2022', 2),
(118, 2, '01.05', '00.35', '00.30', '02.05.2022', 2),
(119, 2, '01.03', '00.31', '00.32', '03.05.2022', 2),
(120, 2, '00.49', '00.22', '00.27', '04.05.2022', 1),
(121, 2, '01.06', '00.31', '00.35', '05.05.2022', 2),
(122, 2, '00.43', '00.19', '00.24', '05.05.2022', 1),
(123, 2, '00.42', '00.16', '00.26', '07.05.2022', 1),
(124, 2, '00.46', '00.22', '00.24', '08.05.2022', 1),
(125, 2, '01.05', '00.35', '00.30', '08.05.2022', 2),
(126, 2, '01.02', '00.25', '00.37', '09.05.2022', 2),
(127, 2, '00.58', '00.25', '00.33', '09.05.2022', 2),
(128, 2, '00.21', '00.05', '00.16', '09.05.2022', 0),
(129, 2, '00.47', '00.24', '00.23', '10.05.2022', 1),
(130, 2, '01.05', '00.35', '00.30', '10.05.2022', 2),
(131, 2, '00.21', '00.08', '00.13', '10.05.2022', 0),
(132, 2, '01.11', '00.35', '00.36', '11.05.2022', 2),
(133, 2, '00.23', '00.06', '00.17', '11.05.2022', 0),
(134, 2, '01.03', '00.28', '00.35', '11.05.2022', 2),
(135, 2, '01.08', '00.31', '00.37', '12.05.2022', 2),
(136, 2, '00.47', '00.20', '00.27', '13.05.2022', 1),
(137, 2, '00.43', '00.22', '00.21', '15.05.2022', 1),
(138, 2, '00.45', '00.25', '00.20', '15.05.2022', 1),
(139, 2, '00.23', '00.07', '00.16', '16.05.2022', 0),
(140, 2, '00.25', '00.13', '00.12', '17.05.2022', 0),
(141, 2, '00.51', '00.25', '00.26', '18.05.2022', 1),
(142, 2, '00.24', '00.14', '00.10', '18.05.2022', 0),
(143, 2, '01.08', '00.32', '00.36', '20.05.2022', 2),
(144, 2, '00.46', '00.24', '00.22', '20.05.2022', 1),
(145, 2, '01.00', '00.27', '00.33', '20.05.2022', 2),
(146, 2, '00.48', '00.22', '00.26', '20.05.2022', 1),
(147, 2, '00.16', '00.06', '00.10', '21.05.2022', 0),
(148, 2, '00.40', '00.19', '00.21', '22.05.2022', 1),
(149, 2, '00.20', '00.07', '00.13', '22.05.2022', 0),
(150, 3, '00.57', '00.27', '00.30', '19.04.2022', 2),
(151, 3, '01.03', '00.29', '00.34', '20.04.2022', 2),
(152, 3, '01.08', '00.35', '00.33', '22.04.2022', 2),
(153, 3, '00.39', '00.15', '00.24', '22.04.2022', 1),
(154, 3, '01.04', '00.28', '00.36', '22.04.2022', 2),
(155, 3, '00.49', '00.23', '00.26', '22.04.2022', 1),
(156, 3, '00.25', '00.09', '00.16', '23.04.2022', 0),
(157, 3, '00.25', '00.15', '00.10', '23.04.2022', 0),
(158, 3, '00.59', '00.26', '00.33', '23.04.2022', 2),
(159, 3, '00.45', '00.18', '00.27', '23.04.2022', 1),
(160, 3, '00.26', '00.12', '00.14', '25.04.2022', 0),
(161, 3, '00.32', '00.15', '00.17', '25.04.2022', 0),
(162, 3, '01.00', '00.26', '00.34', '25.04.2022', 2),
(163, 3, '00.58', '00.26', '00.32', '26.04.2022', 2),
(164, 3, '00.17', '00.05', '00.12', '26.04.2022', 0),
(165, 3, '01.01', '00.28', '00.33', '28.04.2022', 2),
(166, 3, '00.43', '00.19', '00.24', '29.04.2022', 1),
(167, 3, '00.18', '00.06', '00.12', '01.05.2022', 0),
(168, 3, '00.42', '00.19', '00.23', '01.05.2022', 1),
(169, 3, '00.41', '00.18', '00.23', '01.05.2022', 1),
(170, 3, '00.19', '00.06', '00.13', '01.05.2022', 0),
(171, 3, '00.58', '00.26', '00.32', '03.05.2022', 2),
(172, 3, '01.02', '00.31', '00.31', '03.05.2022', 2),
(173, 3, '01.09', '00.33', '00.36', '04.05.2022', 2),
(174, 3, '00.27', '00.13', '00.14', '05.05.2022', 0),
(175, 3, '00.31', '00.14', '00.17', '07.05.2022', 0),
(176, 3, '00.24', '00.08', '00.16', '09.05.2022', 0),
(177, 3, '00.29', '00.14', '00.15', '11.05.2022', 0),
(178, 3, '01.08', '00.33', '00.35', '12.05.2022', 2),
(179, 3, '01.06', '00.33', '00.33', '12.05.2022', 2),
(180, 3, '00.25', '00.15', '00.10', '15.05.2022', 0),
(181, 3, '01.02', '00.30', '00.32', '15.05.2022', 2),
(182, 3, '00.56', '00.25', '00.31', '15.05.2022', 2),
(183, 3, '00.39', '00.17', '00.22', '15.05.2022', 1),
(184, 3, '00.22', '00.07', '00.15', '15.05.2022', 0),
(185, 3, '01.09', '00.32', '00.37', '16.05.2022', 2),
(186, 3, '00.24', '00.13', '00.11', '16.05.2022', 0),
(187, 3, '01.08', '00.31', '00.37', '16.05.2022', 2),
(188, 3, '00.35', '00.15', '00.20', '17.05.2022', 1),
(189, 3, '00.40', '00.15', '00.25', '17.05.2022', 1),
(190, 3, '00.26', '00.13', '00.13', '17.05.2022', 0),
(191, 3, '01.04', '00.28', '00.36', '17.05.2022', 2),
(192, 3, '00.30', '00.13', '00.17', '19.05.2022', 0),
(193, 3, '00.46', '00.25', '00.21', '20.05.2022', 1),
(194, 3, '01.11', '00.35', '00.36', '20.05.2022', 2),
(195, 3, '00.47', '00.20', '00.27', '20.05.2022', 1),
(196, 3, '01.03', '00.30', '00.33', '22.05.2022', 2),
(197, 3, '01.06', '00.34', '00.32', '22.05.2022', 2),
(198, 3, '00.59', '00.29', '00.30', '22.05.2022', 2),
(199, 3, '01.03', '00.26', '00.37', '22.05.2022', 2);

INSERT INTO Quiz_Stats 
VALUES 
(0, 0, 22, 11, 11, '20.04.2022', 0),
(1, 0, 21, 10, 11, '23.04.2022', 0),
(2, 0, 24, 7, 17, '23.04.2022', 0),
(3, 0, 48, 22, 26, '24.04.2022', 1),
(4, 0, 49, 24, 25, '29.04.2022', 1),
(5, 0, 70, 33, 37, '29.04.2022', 2),
(6, 0, 17, 5, 12, '30.04.2022', 0),
(7, 0, 64, 32, 32, '01.05.2022', 2),
(8, 0, 17, 7, 10, '02.05.2022', 0),
(9, 0, 21, 11, 10, '04.05.2022', 0),
(10, 0, 64, 34, 30, '04.05.2022', 2),
(11, 0, 30, 15, 15, '04.05.2022', 0),
(12, 0, 25, 10, 15, '04.05.2022', 0),
(13, 0, 24, 14, 10, '06.05.2022', 0),
(14, 0, 59, 26, 33, '06.05.2022', 2),
(15, 0, 16, 6, 10, '06.05.2022', 0),
(16, 0, 44, 21, 23, '07.05.2022', 1),
(17, 0, 67, 30, 37, '07.05.2022', 2),
(18, 0, 66, 33, 33, '08.05.2022', 2),
(19, 0, 63, 29, 34, '08.05.2022', 2),
(20, 0, 59, 28, 31, '08.05.2022', 2),
(21, 0, 27, 11, 16, '08.05.2022', 0),
(22, 0, 45, 20, 25, '09.05.2022', 1),
(23, 0, 46, 19, 27, '09.05.2022', 1),
(24, 0, 25, 8, 17, '10.05.2022', 0),
(25, 0, 64, 29, 35, '10.05.2022', 2),
(26, 0, 60, 27, 33, '10.05.2022', 2),
(27, 0, 46, 25, 21, '12.05.2022', 1),
(28, 0, 42, 19, 23, '13.05.2022', 1),
(29, 0, 65, 32, 33, '13.05.2022', 2),
(30, 0, 19, 6, 13, '13.05.2022', 0),
(31, 0, 47, 25, 22, '13.05.2022', 1),
(32, 0, 63, 33, 30, '14.05.2022', 2),
(33, 0, 23, 6, 17, '14.05.2022', 0),
(34, 0, 17, 6, 11, '14.05.2022', 0),
(35, 0, 22, 7, 15, '17.05.2022', 0),
(36, 0, 15, 5, 10, '18.05.2022', 0),
(37, 0, 20, 10, 10, '18.05.2022', 0),
(38, 0, 43, 19, 24, '19.05.2022', 1),
(39, 0, 57, 27, 30, '19.05.2022', 2),
(40, 0, 28, 11, 17, '19.05.2022', 0),
(41, 0, 26, 10, 16, '20.05.2022', 0),
(42, 0, 25, 15, 10, '20.05.2022', 0),
(43, 0, 46, 21, 25, '22.05.2022', 1),
(44, 0, 42, 19, 23, '22.05.2022', 1),
(45, 0, 23, 6, 17, '22.05.2022', 0),
(46, 0, 63, 31, 32, '22.05.2022', 2),
(47, 0, 40, 16, 24, '22.05.2022', 1),
(48, 0, 38, 16, 22, '23.05.2022', 1),
(49, 0, 22, 10, 12, '23.05.2022', 0),
(50, 1, 67, 31, 36, '19.04.2022', 2),
(51, 1, 43, 19, 24, '19.04.2022', 1),
(52, 1, 25, 14, 11, '19.04.2022', 0),
(53, 1, 29, 13, 16, '20.04.2022', 0),
(54, 1, 69, 35, 34, '20.04.2022', 2),
(55, 1, 62, 29, 33, '23.04.2022', 2),
(56, 1, 19, 5, 14, '24.04.2022', 0),
(57, 1, 41, 15, 26, '24.04.2022', 1),
(58, 1, 45, 24, 21, '25.04.2022', 1),
(59, 1, 23, 6, 17, '25.04.2022', 0),
(60, 1, 63, 28, 35, '25.04.2022', 2),
(61, 1, 43, 23, 20, '26.04.2022', 1),
(62, 1, 25, 9, 16, '27.04.2022', 0),
(63, 1, 44, 23, 21, '27.04.2022', 1),
(64, 1, 24, 13, 11, '28.04.2022', 0),
(65, 1, 24, 14, 10, '30.04.2022', 0),
(66, 1, 27, 10, 17, '30.04.2022', 0),
(67, 1, 52, 25, 27, '03.05.2022', 1),
(68, 1, 71, 35, 36, '03.05.2022', 2),
(69, 1, 44, 24, 20, '04.05.2022', 1),
(70, 1, 29, 13, 16, '05.05.2022', 0),
(71, 1, 63, 33, 30, '07.05.2022', 2),
(72, 1, 42, 19, 23, '08.05.2022', 1),
(73, 1, 27, 14, 13, '09.05.2022', 0),
(74, 1, 39, 15, 24, '10.05.2022', 1),
(75, 1, 18, 8, 10, '11.05.2022', 0),
(76, 1, 46, 21, 25, '11.05.2022', 1),
(77, 1, 67, 33, 34, '11.05.2022', 2),
(78, 1, 23, 6, 17, '11.05.2022', 0),
(79, 1, 66, 34, 32, '12.05.2022', 2),
(80, 1, 42, 22, 20, '12.05.2022', 1),
(81, 1, 63, 31, 32, '13.05.2022', 2),
(82, 1, 25, 10, 15, '13.05.2022', 0),
(83, 1, 36, 15, 21, '14.05.2022', 1),
(84, 1, 29, 12, 17, '15.05.2022', 0),
(85, 1, 27, 13, 14, '15.05.2022', 0),
(86, 1, 28, 15, 13, '17.05.2022', 0),
(87, 1, 22, 6, 16, '17.05.2022', 0),
(88, 1, 65, 33, 32, '17.05.2022', 2),
(89, 1, 44, 18, 26, '18.05.2022', 1),
(90, 1, 43, 23, 20, '18.05.2022', 1),
(91, 1, 20, 9, 11, '18.05.2022', 0),
(92, 1, 28, 12, 16, '18.05.2022', 0),
(93, 1, 31, 14, 17, '19.05.2022', 0),
(94, 1, 24, 9, 15, '20.05.2022', 0),
(95, 1, 45, 25, 20, '20.05.2022', 1),
(96, 1, 18, 7, 11, '21.05.2022', 0),
(97, 1, 47, 23, 24, '22.05.2022', 1),
(98, 1, 45, 21, 24, '23.05.2022', 1),
(99, 1, 58, 26, 32, '23.05.2022', 2),
(100, 2, 25, 12, 13, '20.04.2022', 0),
(101, 2, 38, 15, 23, '21.04.2022', 1),
(102, 2, 48, 24, 24, '21.04.2022', 1),
(103, 2, 44, 23, 21, '21.04.2022', 1),
(104, 2, 58, 26, 32, '22.04.2022', 2),
(105, 2, 36, 15, 21, '22.04.2022', 1),
(106, 2, 39, 19, 20, '23.04.2022', 1),
(107, 2, 50, 24, 26, '23.04.2022', 1),
(108, 2, 17, 5, 12, '24.04.2022', 0),
(109, 2, 24, 11, 13, '24.04.2022', 0),
(110, 2, 45, 21, 24, '25.04.2022', 1),
(111, 2, 27, 11, 16, '26.04.2022', 0),
(112, 2, 30, 14, 16, '27.04.2022', 0),
(113, 2, 23, 12, 11, '27.04.2022', 0),
(114, 2, 62, 28, 34, '28.04.2022', 2),
(115, 2, 63, 29, 34, '28.04.2022', 2),
(116, 2, 21, 9, 12, '29.04.2022', 0),
(117, 2, 51, 25, 26, '29.04.2022', 1),
(118, 2, 60, 28, 32, '01.05.2022', 2),
(119, 2, 40, 20, 20, '02.05.2022', 1),
(120, 2, 43, 23, 20, '02.05.2022', 1),
(121, 2, 26, 9, 17, '03.05.2022', 0),
(122, 2, 41, 19, 22, '04.05.2022', 1),
(123, 2, 30, 13, 17, '04.05.2022', 0),
(124, 2, 48, 22, 26, '06.05.2022', 1),
(125, 2, 47, 21, 26, '06.05.2022', 1),
(126, 2, 21, 8, 13, '06.05.2022', 0),
(127, 2, 46, 23, 23, '07.05.2022', 1),
(128, 2, 42, 17, 25, '08.05.2022', 1),
(129, 2, 46, 25, 21, '08.05.2022', 1),
(130, 2, 62, 30, 32, '09.05.2022', 2),
(131, 2, 66, 31, 35, '09.05.2022', 2),
(132, 2, 36, 15, 21, '09.05.2022', 1),
(133, 2, 23, 10, 13, '10.05.2022', 0),
(134, 2, 35, 15, 20, '11.05.2022', 1),
(135, 2, 46, 25, 21, '12.05.2022', 1),
(136, 2, 46, 24, 22, '12.05.2022', 1),
(137, 2, 21, 11, 10, '13.05.2022', 0),
(138, 2, 30, 15, 15, '15.05.2022', 0),
(139, 2, 20, 9, 11, '16.05.2022', 0),
(140, 2, 45, 23, 22, '16.05.2022', 1),
(141, 2, 38, 16, 22, '17.05.2022', 1),
(142, 2, 66, 33, 33, '17.05.2022', 2),
(143, 2, 24, 13, 11, '18.05.2022', 0),
(144, 2, 61, 28, 33, '18.05.2022', 2),
(145, 2, 38, 17, 21, '18.05.2022', 1),
(146, 2, 30, 13, 17, '18.05.2022', 0),
(147, 2, 41, 16, 25, '19.05.2022', 1),
(148, 2, 43, 22, 21, '19.05.2022', 1),
(149, 2, 62, 31, 31, '20.05.2022', 2),
(150, 3, 60, 27, 33, '19.04.2022', 2),
(151, 3, 21, 6, 15, '21.04.2022', 0),
(152, 3, 45, 18, 27, '22.04.2022', 1),
(153, 3, 37, 16, 21, '23.04.2022', 1),
(154, 3, 24, 7, 17, '24.04.2022', 0),
(155, 3, 38, 15, 23, '25.04.2022', 1),
(156, 3, 67, 31, 36, '25.04.2022', 2),
(157, 3, 43, 17, 26, '26.04.2022', 1),
(158, 3, 47, 24, 23, '26.04.2022', 1),
(159, 3, 28, 12, 16, '28.04.2022', 0),
(160, 3, 43, 22, 21, '28.04.2022', 1),
(161, 3, 18, 8, 10, '01.05.2022', 0),
(162, 3, 44, 22, 22, '01.05.2022', 1),
(163, 3, 45, 25, 20, '01.05.2022', 1),
(164, 3, 23, 13, 10, '01.05.2022', 0),
(165, 3, 56, 25, 31, '01.05.2022', 2),
(166, 3, 65, 34, 31, '03.05.2022', 2),
(167, 3, 58, 25, 33, '03.05.2022', 2),
(168, 3, 16, 6, 10, '03.05.2022', 0),
(169, 3, 21, 9, 12, '05.05.2022', 0),
(170, 3, 43, 20, 23, '05.05.2022', 1),
(171, 3, 41, 20, 21, '06.05.2022', 1),
(172, 3, 19, 9, 10, '08.05.2022', 0),
(173, 3, 43, 19, 24, '08.05.2022', 1),
(174, 3, 65, 30, 35, '09.05.2022', 2),
(175, 3, 47, 21, 26, '10.05.2022', 1),
(176, 3, 18, 5, 13, '11.05.2022', 0),
(177, 3, 63, 26, 37, '11.05.2022', 2),
(178, 3, 49, 24, 25, '11.05.2022', 1),
(179, 3, 64, 30, 34, '12.05.2022', 2),
(180, 3, 69, 32, 37, '14.05.2022', 2),
(181, 3, 22, 10, 12, '15.05.2022', 0),
(182, 3, 48, 21, 27, '15.05.2022', 1),
(183, 3, 24, 9, 15, '16.05.2022', 0),
(184, 3, 71, 35, 36, '17.05.2022', 2),
(185, 3, 44, 19, 25, '17.05.2022', 1),
(186, 3, 22, 7, 15, '17.05.2022', 0),
(187, 3, 59, 27, 32, '18.05.2022', 2),
(188, 3, 43, 22, 21, '18.05.2022', 1),
(189, 3, 23, 9, 14, '18.05.2022', 0),
(190, 3, 63, 31, 32, '18.05.2022', 2),
(191, 3, 19, 6, 13, '19.05.2022', 0),
(192, 3, 65, 32, 33, '19.05.2022', 2),
(193, 3, 42, 19, 23, '20.05.2022', 1),
(194, 3, 20, 6, 14, '20.05.2022', 0),
(195, 3, 24, 11, 13, '21.05.2022', 0),
(196, 3, 28, 14, 14, '22.05.2022', 0),
(197, 3, 38, 16, 22, '22.05.2022', 1),
(198, 3, 70, 35, 35, '22.05.2022', 2),
(199, 3, 63, 30, 33, '22.05.2022', 2);

INSERT INTO dbo.Users
VALUES
(0, 'beni', '123', 'beni@id.com', NULL),
(1, 'man', '123', 'man@id.com', NULL),
(2, 'ioan', '123', 'ioan@popa.com', NULL),
(3, 'darius', '123', 'darius@gmail.com', NULL),
(4, 'admin', 'admin123', NULL, 1);

INSERT INTO dbo.Categories
VALUES
(0, 'General Knowledge'),
(1, 'Physics'),
(2, 'Chemistry'),
(3, 'Biology'),
(4, 'Technology'),
(5, 'Geography');