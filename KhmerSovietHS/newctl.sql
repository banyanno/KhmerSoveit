CREATE CONTROLFILE REUSE DATABASE "CBSMRS" NORESETLOGS FORCE LOGGING NOARCHIVELOG
    MAXLOGFILES 16
    MAXLOGMEMBERS 3
    MAXDATAFILES 100
    MAXINSTANCES 8
    MAXLOGHISTORY 5840
LOGFILE
  GROUP 1 (
    '/oradata/CBSMRS/redo01_01.log',
    '/oradata/CBSMRS/redo01_02.log'
  ) SIZE 50M,
  GROUP 2 (
    '/oradata/CBSMRS/redo02_01.log',
    '/oradata/CBSMRS/redo02_02.log'
  ) SIZE 50M,
  GROUP 3 (
    '/oradata/CBSMRS/redo03_01.log',
    '/oradata/CBSMRS/redo03_02.log'
  ) SIZE 50M
-- STANDBY LOGFILE
--   GROUP 4 '/oradata/FCJPROD/stage/stredo01.log'  SIZE 50M,
--   GROUP 5 '/oradata/FCJPROD/stage/stredo02.log'  SIZE 50M,
--   GROUP 6 '/oradata/FCJPROD/stage/stredo03.log'  SIZE 50M,
--   GROUP 7 '/oradata/FCJPROD/stage/stredo04.log'  SIZE 50M
DATAFILE
  '/oradata/CBSMRS/system01.dbf',
  '/oradata/CBSMRS/UNDOTBS01.DBF',
  '/oradata/CBSMRS/sysaux01.dbf',
  '/oradata/CBSMRS/users01.dbf',
  '/oradata/CBSMRS/NBCPROD01.DBF',
  '/oradata/CBSMRS/orabpel.dbf',
  '/oradata/CBSMRS/NBCARC01.DBF'
CHARACTER SET AL32UTF8
;