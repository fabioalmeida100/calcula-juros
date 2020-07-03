docker build --pull -t calculajuros .
docker run --rm -it -p 8001:80 calculajuros