#!/bin/sh
set -e

# Injetar ApiBaseUrl em appsettings.json se fornecido
if [ -n "$API_BASE_URL" ]; then
  echo "{\"ApiBaseUrl\":\"$API_BASE_URL\"}" > /usr/share/nginx/html/appsettings.json
fi

# Ajustar base href se fornecido (ex: /BlazorAutoCotacao/)
if [ -n "$BASE_HREF" ]; then
  sed -i "s|<base href=\"/\" />|<base href=\"$BASE_HREF\" />|g" /usr/share/nginx/html/index.html || true
fi

exec nginx -g 'daemon off;'
