SELECT pg_terminate_backend(A.pid) FROM pg_stat_activity AS A WHERE A.datname='EduBaseDemo' AND A.pid<>pg_backend_pid();