docker build --pull -t retornajuros .
docker run --rm -it -p 8001:80 retornajuros