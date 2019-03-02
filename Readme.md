# .net core and graphql

Small playground project to play around with GraphQL (https://graphql.org/) and .net core.
Project uses middleware instead of controllers to provide access to the data behind the scenes.

When project is started navigate to `/ui/playground` and playaround with data.
Example of query:

```javascript
{ users {
        firstName,
        lastName
    }
}
```
