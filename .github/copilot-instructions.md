# Copilot Instructions

## 项目指南
- In this repo, prefer Dapper with Microsoft.Data.SqlClient for SQL Server data access code.
- Use naming conventions: 
  - BLL classes/files should use service-style names like `UserService`, `ProductService`, `PermissionService`.
  - DAL should also use clear service-style names.
  - UI should use repository-style names like `UserRepository`, `ProductRecordRepository`.
  - Models should use readable entity names like `UserInfo`, `ProductRecord`, `SystemConfig`, `Permission`, `ProductState`.
  - Common should use helper/factory names like `DbConnectionFactory`, `ConfigHelper`, `LogHelper`, `JsonHelper`, `FileHelper`. 
- Prefer规范、易读的命名。
- 在枚举中直接使用中文名称，而不是维护单独的UI显示映射，例如`List<KeyValuePair<string, Permission>>`。