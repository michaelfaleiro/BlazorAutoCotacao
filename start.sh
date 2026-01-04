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

# Substituir placeholder de CSP connect-src com host(s) da API em tempo de execução.
# Use API_CSP_HOST diretamente se fornecido, senão extrai a origem de API_BASE_URL.
if [ -n "$API_CSP_HOST" ] || [ -n "$API_BASE_URL" ]; then
  if [ -n "$API_CSP_HOST" ]; then
    CSP_HOSTS="$API_CSP_HOST"
  else
    CSP_HOSTS=$(echo "$API_BASE_URL" | awk -F/ '{print $1 "//" $3}')
  fi
  sed -i "s|%%API_CSP_HOST%%|$CSP_HOSTS|g" /usr/share/nginx/html/index.html || true
else
  # remove placeholder se não fornecido
  sed -i "s|%%API_CSP_HOST%%||g" /usr/share/nginx/html/index.html || true
fi

exec nginx -g 'daemon off;'
