FROM apline

RUN apk update && apk mariadb mariadb-client && \
    mysql_install_db --user=mysql

VOLUME /var/lib/mysql && \
       var/log/mysql

EXPOSE 8081
