<template>
	<view class="container container333545">
		<text class="diygw-col-24 text-clz"> 欢迎使用 </text>
		<text class="diygw-col-24 text1-clz"> 人力资源系统 </text>
		<u-form :model="form" :rules="formRules" :errorType="['message', 'toast']" ref="formRef" class="flex diygw-form diygw-col-24">
			<u-form-item class="diygw-col-24 userName-clz" labelPosition="top" prop="userName">
				<text class="diy-icon-people margin-right-xs" style="color: #636363; font-size: 32rpx"></text>
				<u-input :focus="formData.userNameFocus" placeholder="请输入用户名" v-model="form.userName"></u-input>
			</u-form-item>
			<u-form-item v-if="globalData.logintype != '1'" class="diygw-col-24 password-clz" labelPosition="top" prop="password">
				<text class="diy-icon-lock margin-right-xs" style="color: #636363; font-size: 32rpx"></text>
				<u-input :focus="formData.passwordFocus" placeholder="请输入密码" v-model="form.password" type="password" :password-icon="true"></u-input>
			</u-form-item>
			<u-form-item class="diygw-col-24" label="系统" prop="sctdown">
				<view class="diygw-col-24 flex flex-direction-column">
					<diy-selectinput @click="formData.showSctdown = true" class="diygw-col-24" valueName="value" labelName="label" :list="formData.sctdownDatas" placeholder="请选择登录系统" v-model="form.sctdown" type="select"></diy-selectinput>
					<diy-selectdown ref="FormsctdownRef" :trigger-id="`formDatasctdown`" v-model="formData.showSctdown" valueName="value" labelName="label" :list="formData.sctdownDatas" :defaultValue="form.sctdown" @change="changeFormSctdown"> </diy-selectdown>
				</view>
			</u-form-item>
			<text @click="submitForm" class="diygw-col-24 gradual-green text4-clz"> 登录 </text>
			<view class="flex flex-wrap diygw-col-0 items-center flex3-clz">
				<view class="flex flex-wrap diygw-col-0 items-center" @tap="navigateTo" data-type="agreeFunction">
					<text v-if="globalData.agree == '1'" class="flex icon3 diygw-col-0 icon3-clz diy-icon-roundcheck"></text>
					<text v-if="globalData.agree != '1'" class="flex icon2 diygw-col-0 icon2-clz diy-icon-round"></text>
					<text class="diygw-col-0"> 登录即同意并接受 </text>
				</view>
				<text @tap="navigateTo" data-type="page" data-url="/pages/null" data-newstype="privacy" class="diygw-col-0 text11-clz"> 《隐私权政策》 </text>
				<text class="diygw-col-0"> 和 </text>
				<text @tap="navigateTo" data-type="page" data-url="/pages/null" data-newstype="user" class="diygw-col-0 text13-clz"> 《用户协议》 </text>
			</view>
		</u-form>
		<!-- #ifdef  -->
		<view class="flex flex-wrap diygw-col-24 flex-direction-column">
			<view class="flex flex-wrap diygw-col-24 items-center flex2-clz" @tap="navigateTo" data-type="agreeFunction">
				<view class="flex diygw-col-0 line-clz">
					<view class="diygw-pzx" style="border-bottom: 1px solid #eee"></view>
				</view>
				<text class="diygw-col-0 text6-clz"> 第三方登录 </text>
				<view class="flex diygw-col-0 line1-clz">
					<view class="diygw-pzx" style="border-bottom: 1px solid #eee"></view>
				</view>
			</view>
			<view class="flex flex-wrap diygw-col-24 justify-around items-center flex4-clz">
				<image src="/static/wx1.png" class="image-size diygw-image diygw-col-0" mode="widthFix"></image>
				<image src="/static/zfb.png" class="image2-size diygw-image diygw-col-0" mode="widthFix"></image>
				<image src="/static/wb.png" class="image1-size diygw-image diygw-col-0" mode="widthFix"></image>
			</view>
		</view>
		<!--  #endif -->
		<view class="clearfix"></view>
	</view>
</template>

<script>
	export default {
		data() {
			return {
				//用户全局信息
				userInfo: {},
				//页面传参
				globalOption: {},
				//自定义全局变量
				globalData: { logintype: '0', localurl: '0', agree: '0' },
				getIP: ``,
				getSystemSet: ``,
				formRules: {
					userName: [
						{
							trigger: ['change', 'blur'],
							required: true,
							message: '用户名不能为空'
						}
					],
					password: [
						{
							trigger: ['change', 'blur'],
							required: true,
							message: '密码不能为空'
						}
					]
				},
				form: {
					userName: '',
					password: '',
					sctdown: '1'
				},
				formData: {
					userNameFocus: false,
					passwordFocus: false,
					showSctdown: false,
					sctdownDatas: [
						{ value: '1', label: '选项一' },
						{ value: '2', label: '选项二' },
						{ value: '3', label: '选项三' }
					]
				}
			};
		},
		onShow() {
			this.setCurrentPage(this);
		},
		onLoad(option) {
			this.setCurrentPage(this);
			if (option) {
				this.setData({
					globalOption: this.getOption(option)
				});
			}

			this.init();
		},
		onReady() {
			this.$refs.formRef?.setRules(this.formRules);
		},
		methods: {
			async init() {
				this.getIPApi();
				this.getSystemSetApi();
				await this.initResetform();
			},
			// 获取本机IP API请求方法
			async getIPApi(param) {
				let thiz = this;
				param = param || {};

				//请求地址及请求数据，可以在加载前执行上面增加自己的代码逻辑
				let http_url = '/api/User/GetIP';
				let http_data = {};
				let http_header = {
					'Content-Type': 'application/json'
				};

				let getIP = await this.$http.get(http_url, http_data, http_header, 'json');

				this.getIP = getIP;
				this.globalData.localurl = this.getIP.IPAddress;
			},
			// 获取系统设置 API请求方法
			async getSystemSetApi(param) {
				let thiz = this;
				param = param || {};

				//请求地址及请求数据，可以在加载前执行上面增加自己的代码逻辑
				let http_url = '/api/User/GetSystemSet';
				let http_data = {};
				let http_header = {
					'Content-Type': 'application/json'
				};

				let getSystemSet = await this.$http.get(http_url, http_data, http_header, 'json');

				this.getSystemSet = getSystemSet;
			},

			// 同意或不同意 自定义方法
			async agreeFunction(param) {
				let thiz = this;
				//如果不同意，改为同意
				this.globalData.agree = this.globalData.agree == '1' ? '0' : '1';
			},
			closeFormSctdown() {
				this.$refs.FormsctdownRef.close();
			},
			changeFormSctdown(evt) {
				this.form.sctdown = evt;
			},
			initResetform() {
				this.initform = JSON.stringify(this.form);
				//如果想给表单默认初始值，其中row为某一行数据也可能是API返回的结果集，然后给到this.form
				//this.form = this.$tools.changeRowToForm(row,this.form)
			},
			resetForm() {
				this.form = JSON.parse(this.initform);
			},

			async submitForm(e) {
				this.$refs.formRef?.setRules(this.formRules);

				this.$nextTick(async () => {
					let valid = await this.$refs.formRef.validate();
					if (valid) {
						//保存数据
						let param = this.form;
						let header = {
							'Content-Type': 'application/json'
						};
						let url = '/api/User/Login';

						if (this.globalData.agree != '1') {
							this.showToast('请点击同意授权协议');
							return;
						}
						try {
							const response = await fetch('https://localhost:44315/api/User/GetIP');
							const data = await response.json();
							this.globalData.localurl = data.IPAddress;
						} catch (error) {
							console.error('获取IP地址时出错:', error);
						}
						param.localurl = this.globalData.localurl;
						param.logintype = this.globalData.logintype;
						let res = await this.$http.post(url, param, header, 'json');
						if (res.state == 'success') {
							this.showToast(res.message, 'success');
							this.$session.setUser(res.data);
							setTimeout(() => {
								this.navigateTo({ type: 'page', url: '/pages/yewu/index' });
							}, 1500);
						} else {
							this.showModal(res.message, '提示', false);
						}
					} else {
						console.log('验证失败');
					}
				});
			}
		}
	};
</script>

<style lang="scss" scoped>
	.text-clz {
		margin-left: 10rpx;
		padding-top: 180rpx;
		font-weight: bold;
		padding-left: 20rpx;
		width: calc(100% - 10rpx - 10rpx) !important;
		font-size: 32rpx !important;
		padding-bottom: 10rpx;
		margin-top: 10rpx;
		margin-bottom: 0rpx;
		margin-right: 10rpx;
		padding-right: 20rpx;
	}
	.text1-clz {
		margin-left: 10rpx;
		padding-top: 10rpx;
		font-weight: bold;
		padding-left: 20rpx;
		width: calc(100% - 10rpx - 10rpx) !important;
		font-size: 32rpx !important;
		padding-bottom: 10rpx;
		margin-top: 0rpx;
		margin-bottom: 10rpx;
		margin-right: 10rpx;
		padding-right: 20rpx;
	}
	.userName-clz {
		margin-left: 10rpx;
		width: calc(100% - 10rpx - 10rpx) !important;
		font-size: 28rpx !important;
		margin-top: 10rpx;
		margin-bottom: 10rpx;
		margin-right: 10rpx;
	}
	.password-clz {
		margin-left: 10rpx;
		width: calc(100% - 10rpx - 10rpx) !important;
		font-size: 28rpx !important;
		margin-top: 10rpx;
		margin-bottom: 10rpx;
		margin-right: 10rpx;
	}
	.text4-clz {
		padding-top: 20rpx;
		border-bottom-left-radius: 120rpx;
		color: #ffffff;
		font-weight: bold;
		letter-spacing: 6rpx !important;
		padding-left: 10rpx;
		font-size: 32rpx !important;
		padding-bottom: 20rpx;
		border-top-right-radius: 120rpx;
		margin-right: 30rpx;
		margin-left: 30rpx;
		box-shadow: 0rpx 6rpx 14rpx rgba(64, 195, 3, 0.35);
		overflow: hidden;
		width: calc(100% - 30rpx - 30rpx) !important;
		border-top-left-radius: 120rpx;
		margin-top: 10rpx;
		border-bottom-right-radius: 120rpx;
		margin-bottom: 10rpx;
		text-align: center;
		padding-right: 10rpx;
	}
	.flex3-clz {
		padding-top: 16rpx;
		padding-left: 30rpx;
		padding-bottom: 16rpx;
		padding-right: 30rpx;
	}
	.icon3-clz {
		color: #39b54a;
	}
	.icon3 {
		font-size: 40rpx;
	}
	.icon2-clz {
		color: #39b54a;
	}
	.icon2 {
		font-size: 40rpx;
	}
	.text11-clz {
		color: #39b54a;
	}
	.text13-clz {
		color: #39b54a;
	}
	.flex2-clz {
		margin-left: 10rpx;
		padding-top: 16rpx;
		padding-left: 30rpx;
		width: calc(100% - 10rpx - 10rpx) !important;
		padding-bottom: 16rpx;
		margin-top: 30rpx;
		margin-bottom: 10rpx;
		margin-right: 10rpx;
		padding-right: 30rpx;
	}
	.line-clz {
		flex: 1;
	}
	.text6-clz {
		padding-top: 10rpx;
		padding-left: 10rpx;
		padding-bottom: 10rpx;
		padding-right: 10rpx;
	}
	.line1-clz {
		flex: 1;
	}
	.flex4-clz {
		padding-top: 16rpx;
		padding-left: 30rpx;
		padding-bottom: 16rpx;
		padding-right: 30rpx;
	}
	.image-size {
		height: 80rpx !important;
		width: 80rpx !important;
	}
	.image2-size {
		height: 80rpx !important;
		width: 80rpx !important;
	}
	.image1-size {
		height: 80rpx !important;
		width: 80rpx !important;
	}
	.container333545 {
		background-image: url(/static/mbz704.png);
		background-position: top center;
		background-size: contain;
		background-repeat: no-repeat;
	}
</style>
