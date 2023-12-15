# CONSOLE COMMANDS

## cURL

```bash
curl -X 'POST' \
  'https://localhost:7146/expressionMatch' \
  -H 'accept: */*' \
  -H 'Content-Type: application/json' \
  -d '{
  "sentence": "abc",
  "pattern": "a.c"
}'
```
