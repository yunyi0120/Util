# Unity UPM包发布指南

## 发布方式

### 1. 整个Unity项目Git仓库方式（推荐）

这是最推荐的方式，将整个Unity项目上传到Git，然后通过指定子文件夹来发布包。

#### 步骤：

1. **在项目根目录初始化Git仓库**
   ```bash
   # 在 E:\Unity\Util 目录下
   git init
   git add .
   git commit -m "Initial commit: Unity project with Utils package"
   ```

2. **创建.gitignore文件**
   ```bash
   # 添加Unity项目的.gitignore
   # 可以从 https://github.com/github/gitignore/blob/main/Unity.gitignore 获取
   ```

3. **推送到远程仓库**
   ```bash
   git remote add origin https://github.com/yourusername/unity-utils-project.git
   git push -u origin main
   ```

4. **为包创建版本标签**
   ```bash
   git tag upm/v1.0.0
   git push origin upm/v1.0.0
   ```

#### 在其他项目中使用：

**方式1：通过子文件夹路径**
在目标项目的`Packages/manifest.json`中添加：
```json
{
  "dependencies": {
    "com.yf.utils": "https://github.com/yourusername/unity-utils-project.git?path=/Assets/Utils"
  }
}
```

**方式2：指定标签版本**
```json
{
  "dependencies": {
    "com.yf.utils": "https://github.com/yourusername/unity-utils-project.git?path=/Assets/Utils#upm/v1.0.0"
  }
}
```

### 2. 仅包文件夹Git仓库方式

如果只想发布包本身，可以单独为包创建仓库。

#### 步骤：

1. **初始化包目录的Git仓库**
   ```bash
   cd Assets/Utils
   git init
   git add .
   git commit -m "Initial commit: Unity Utils package"
   ```

2. **推送到远程仓库**
   ```bash
   git remote add origin https://github.com/yourusername/unity-utils.git
   git push -u origin main
   ```

3. **创建版本标签**
   ```bash
   git tag v1.0.0
   git push origin v1.0.0
   ```

#### 在其他项目中使用：

```json
{
  "dependencies": {
    "com.yf.utils": "https://github.com/yourusername/unity-utils.git"
  }
}
```

### 2. 本地文件夹方式

适用于开发阶段或内部项目。

#### 在其他项目中使用：

在目标项目的`Packages/manifest.json`中添加：
```json
{
  "dependencies": {
    "com.yf.utils": "file:../path/to/your/utils/package"
  }
}
```

### 3. OpenUPM方式

如果要发布到OpenUPM（Unity包管理社区），需要：

1. 创建GitHub仓库
2. 在OpenUPM网站提交包申请
3. 等待审核通过

### 4. Unity Asset Store方式

通过Unity Asset Store发布：

1. 准备Asset Store所需的资料
2. 提交到Unity Asset Store
3. 等待审核

## 版本管理

### 更新版本
1. 修改`package.json`中的版本号
2. 提交更改
3. 创建新的Git标签

```bash
git add .
git commit -m "Update to version 1.1.0"
git tag v1.1.0
git push origin main
git push origin v1.1.0
```

### 语义化版本控制
- **主版本号**：不兼容的API修改
- **次版本号**：向下兼容的功能性新增
- **修订号**：向下兼容的问题修正

## 最佳实践

1. **包结构规范**
   - 保持清晰的文件夹结构
   - 正确配置Assembly Definition文件
   - 添加适当的测试

2. **文档完善**
   - 编写清晰的README文档
   - 提供API文档
   - 包含使用示例

3. **版本控制**
   - 使用语义化版本控制
   - 为每个版本创建Git标签
   - 维护更新日志

4. **测试覆盖**
   - 为核心功能编写单元测试
   - 在不同Unity版本中测试兼容性
