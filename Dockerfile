FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src
COPY . .

# Publish Blazor WebAssembly app
RUN dotnet publish BlazorAutoCotacao/BlazorAutoCotacao.csproj -c Release -o /app/publish -p:GHPages=true

FROM nginx:stable-alpine
COPY nginx.conf /etc/nginx/conf.d/default.conf
# Copy entire publish output then place correct files into nginx html dir
COPY --from=build /app/publish /tmp/publish
RUN mkdir -p /usr/share/nginx/html \
	&& if [ -d /tmp/publish/wwwroot ]; then \
			 cp -r /tmp/publish/wwwroot/* /usr/share/nginx/html/; \
		 else \
			 cp -r /tmp/publish/* /usr/share/nginx/html/; \
		 fi \
	&& rm -rf /tmp/publish
COPY start.sh /usr/local/bin/start.sh
RUN chmod +x /usr/local/bin/start.sh
ENTRYPOINT ["/usr/local/bin/start.sh"]
