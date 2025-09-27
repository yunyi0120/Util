# Changelog

All notable changes to this package will be documented in this file.

The format is based on [Keep a Changelog](http://keepachangelog.com/en/1.0.0/)
and this project adheres to [Semantic Versioning](http://semver.org/spec/v2.0.0.html).

## [1.0.1] - 2024-09-27

### Added
- Editor Assembly Definition文件，修复了Editor脚本编译问题
- Unity菜单工具：Utils菜单项
- 清空控制台快捷键（Ctrl+Shift+C）
- 完整的发布指南文档

### Fixed
- 修复了Editor脚本无法编译的问题
- 修复了Assembly Definition文件引用错误

### Changed
- 更新了包的命名规范，统一使用com.yf.utils
- 改进了项目结构和文档

## [1.0.0] - 2024-09-27

### Added
- 初始版本发布
- DebugUtils工具类，提供彩色日志输出功能
  - LogWithColor: 自定义颜色日志
  - LogError: 红色错误日志
  - LogWarning: 黄色警告日志  
  - LogSuccess: 绿色成功日志
- Runtime Assembly Definition配置
- 基础的UPM包结构
- package.json配置文件

### Features
- 支持Unity 2021.3及以上版本
- 完整的Assembly Definition配置
- 标准的UPM包文件夹结构
