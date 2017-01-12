
// GenericCallbackAppDlg.h : header file
//
#include <comutil.h>
#include <ole2.h>
#include <malloc.h>

#pragma once
void __stdcall AxScanCallback(LONG lpId, LONG_PTR lpInfo);
#define EVENT_FINISHED		WM_USER
#import <GenericaCallbackDLL.tlb>
using namespace GenericaCallbackDLL;
// CGenericCallbackAppDlg dialog
class CGenericCallbackAppDlg : public CDialogEx
{
// Construction
public:
	CGenericCallbackAppDlg(CWnd* pParent = NULL);	// standard constructor

// Dialog Data
#ifdef AFX_DESIGN_TIME
	enum { IDD = IDD_GENERICCALLBACKAPP_DIALOG };
#endif

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support
	friend void _stdcall AxScanCallBack(LONG, LONG_PTR);

// Implementation
protected:
	HICON m_hIcon;

	// Generated message map functions
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	DECLARE_MESSAGE_MAP()
public:
	afx_msg void OnBnClickedButton1();
	virtual BOOL OnCommand(WPARAM wParam, LPARAM lParam);
private:
	IDllAPIPtr m_GenericDll;
};
