
# Elastic Counter Web App Example with Clean Core

## Elastic Setup

## Set Passwords

	export ELASTIC_PASSWORD="<ES_PASSWORD>"  # password for "elastic" username


	export KIBANA_PASSWORD="<KIB_PASSWORD>"   # Used _internally_ by Kibana, must be at least 6 characters long
### Create a network
	docker network create elastic-net

### Start Elasticsearch
	docker run -p 127.0.0.1:9200:9200 -d --name elasticsearch --network elastic-net -e ELASTIC_PASSWORD=$ELASTIC_PASSWORD -e "discovery.type=single-node" -e "xpack.security.http.ssl.enabled=false" -e "xpack.license.self_generated.type=trial" docker.elastic.co/elasticsearch/elasticsearch:8.14.0

### Set Kibana Password in Elasticsearch
	curl -u elastic:$ELASTIC_PASSWORD -X POST http://localhost:9200/_security/user/kibana_system/_password -d '{"password":"'"$KIBANA_PASSWORD"'"}' -H 'Content-Type: application/json'

### Start Kibana
	docker run -p 127.0.0.1:5601:5601 -d --name kibana --network elastic-net -e ELASTICSEARCH_URL=http://elasticsearch:9200 -e ELASTICSEARCH_HOSTS=http://elasticsearch:9200 -e ELASTICSEARCH_USERNAME=kibana_system -e ELASTICSEARCH_PASSWORD=$KIBANA_PASSWORD -e "xpack.security.enabled=false" -e "xpack.license.self_generated.type=trial" docker.elastic.co/kibana/kibana:8.14.0