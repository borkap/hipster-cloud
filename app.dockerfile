# ** Build

FROM node:12 as build
WORKDIR /app

# React app can't access env vars after it's built
# so we need to set parameters before the build
ARG API_URL=http://localhost:5000
ARG APP_URL=http://localhost:3000

ENV REACT_APP_API_URL=${API_URL}
ENV PUBLIC_URL=${APP_URL}

COPY Hipster.App/package.json .
COPY Hipster.App/package-lock.json .

RUN npm install --silent

COPY Hipster.App/tsconfig.json .
COPY Hipster.App/public/ public/
COPY Hipster.App/src/ src/

RUN npm run build

# ** Run

FROM nginx:1.16.0 as run

EXPOSE 80
EXPOSE 443

COPY --from=build /app/build /usr/share/nginx/html

ENTRYPOINT ["nginx", "-g", "daemon off;"]