<script>
	export default {
		globalData: {
			userInfo: null,
			tabBar: [],
			homePage: '/pages/login',
			pages: ['/pages/login', '/pages/index'],
			userData: {}
		},
		onLaunch() {
			if (this.$session.getUser()) {
				// 已登录，跳转到首页
				uni.navigateTo({
					url: '/pages/yewu/index'
				});
			} else {
				// 未登录，跳转到登录页
				uni.navigateTo({
					url: '/pages/login'
				});
				this.showToast('请先登录');
			}
		}
	};
</script>
<style lang="scss">
	@import 'common/diygw-ui/iconfont.scss';
	@import 'common/diygw-ui/animate.css';
	@import 'common/diygw-ui/index.scss';

	@import './uni_modules/diy-uview-ui/index.scss';
	@import 'common/diygw-ui/uview.scss';
</style>
